using AutoServis.Models.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminUsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminUsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.OrderBy(u => u.Email).ToList();

            var list = new List<UserListItemVM>();
            foreach (var u in users)
            {
                var roles = await _userManager.GetRolesAsync(u);
                list.Add(new UserListItemVM
                {
                    Id = u.Id,
                    Email = u.Email,
                    UserName = u.UserName,
                    IsActive = !(u.LockoutEnd.HasValue && u.LockoutEnd.Value > DateTimeOffset.UtcNow),
                    Roles = roles
                });
            }

            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var vm = new UserCreateVM
            {
                Roles = await GetAllRolesForCheckboxesAsync()
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Roles = await GetAllRolesForCheckboxesAsync(vm.Roles);
                return View(vm);
            }

            var user = new IdentityUser
            {
                UserName = vm.Email,
                Email = vm.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, vm.Password);
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors) ModelState.AddModelError("", e.Description);
                vm.Roles = await GetAllRolesForCheckboxesAsync(vm.Roles);
                return View(vm);
            }

            await SyncRolesAsync(user, vm.Roles);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);
            var vm = new UserEditVM
            {
                Id = user.Id,
                Email = user.Email ?? "",
                UserName = user.UserName ?? "",
                IsActive = !(user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTimeOffset.UtcNow),
                Roles = (await _roleManager.Roles.Select(r => r.Name!).ToListAsync())
                    .Select(rn => new RoleCheckVM { Name = rn, Selected = userRoles.Contains(rn) })
                    .ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserEditVM vm)
        {
            var user = await _userManager.FindByIdAsync(vm.Id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid)
            {
                vm.Roles = await GetAllRolesForCheckboxesAsync(vm.Roles);
                return View(vm);
            }

            var currentId = _userManager.GetUserId(User);
            if (user.Id == currentId && vm.IsActive == false)
            {
                ModelState.AddModelError("", "Ne možete deaktivirati vlastiti administratorski račun.");
                vm.Roles = await GetAllRolesForCheckboxesAsync(vm.Roles);
                return View(vm);
            }

            user.Email = vm.Email;
            user.UserName = string.IsNullOrWhiteSpace(vm.UserName) ? vm.Email : vm.UserName;

            var updateRes = await _userManager.UpdateAsync(user);
            if (!updateRes.Succeeded)
            {
                foreach (var e in updateRes.Errors) ModelState.AddModelError("", e.Description);
                vm.Roles = await GetAllRolesForCheckboxesAsync(vm.Roles);
                return View(vm);
            }

            await SetActiveAsync(user, vm.IsActive);

            await SyncRolesAsync(user, vm.Roles);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleActive(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var currentId = _userManager.GetUserId(User);
            if (user.Id == currentId)
                return BadRequest("Ne možete deaktivirati vlastiti račun.");

            var isActive = !(user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTimeOffset.UtcNow);
            await SetActiveAsync(user, !isActive);

            return RedirectToAction(nameof(Index));
        }

        private async Task SetActiveAsync(IdentityUser user, bool isActive)
        {
            if (!user.LockoutEnabled)
                await _userManager.SetLockoutEnabledAsync(user, true);

            if (isActive)
                await _userManager.SetLockoutEndDateAsync(user, null);
            else
                await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.MaxValue);
        }

        private async Task<List<RoleCheckVM>> GetAllRolesForCheckboxesAsync(List<RoleCheckVM>? existing = null)
        {
            var all = _roleManager.Roles.Select(r => r.Name!).ToList();
            var set = existing?.ToDictionary(x => x.Name, x => x.Selected) ?? new Dictionary<string, bool>();

            return all.Select(rn => new RoleCheckVM
            {
                Name = rn,
                Selected = set.TryGetValue(rn, out var sel) && sel
            }).ToList();
        }

        private async Task SyncRolesAsync(IdentityUser user, List<RoleCheckVM> roles)
        {
            var selected = roles.Where(r => r.Selected).Select(r => r.Name).ToList();
            var current = await _userManager.GetRolesAsync(user);

            var toAdd = selected.Except(current).ToList();
            var toRemove = current.Except(selected).ToList();

            if (toRemove.Any())
                await _userManager.RemoveFromRolesAsync(user, toRemove);

            if (toAdd.Any())
                await _userManager.AddToRolesAsync(user, toAdd);
        }

        public async Task<IActionResult> ResetPassword(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return NotFound();

            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var vm = new UserResetPasswordVM
            {
                Id = user.Id,
                Email = user.Email ?? user.UserName ?? ""
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(UserResetPasswordVM vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var user = await _userManager.FindByIdAsync(vm.Id);
            if (user == null) return NotFound();

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, vm.NewPassword);

            if (!result.Succeeded)
            {
                foreach (var e in result.Errors)
                    ModelState.AddModelError("", e.Description);

                vm.Email = user.Email ?? user.UserName ?? "";
                return View(vm);
            }

            TempData["Success"] = "Lozinka je uspješno promijenjena.";
            return RedirectToAction(nameof(Edit), new { id = user.Id });
        }
    }
}
