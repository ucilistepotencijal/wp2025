using Microsoft.AspNetCore.Identity;

namespace AutoServis.Data
{
    public static class IdentitySeeder
    {
        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null) throw new ArgumentNullException(nameof(serviceProvider));

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "Customer" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            const string adminEmail = "voditelj@ucilistepotencijal.hr";
            const string adminPassword = "Admin123!";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var newAdminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var createAdminUser = await userManager.CreateAsync(newAdminUser, adminPassword);
                if (createAdminUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAdminUser, "Admin");
                    adminUser = newAdminUser;
                }
            }

            if (adminUser != null && !await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
