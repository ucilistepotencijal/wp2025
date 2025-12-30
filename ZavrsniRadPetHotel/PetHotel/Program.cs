using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data; // Provjeri je li ovo tvoj to?an namespace (ime projekta.Data)
using PetHotel.Models;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// --- 1. POSTAVKE BAZE PODATAKA ---
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// --- 2. POSTAVKE KORISNIKA (IDENTITY) ---
builder.Services.AddDefaultIdentity<IdentityUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
.AddRoles<IdentityRole>() // Omogu?uje Admin ulogu
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// --- 3. LOKALIZACIJA (HRVATSKI JEZIK) ---
var hrCulture = new CultureInfo("hr-HR");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(hrCulture);
    options.SupportedCultures = new[] { hrCulture };
    options.SupportedUICultures = new[] { hrCulture };
});

var app = builder.Build();

// --- 4. KONFIGURACIJA HTTP CJEVOVODA (MIDDLEWARE) ---
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Postavljanje HR kulture za datume i brojeve
CultureInfo.DefaultThreadCurrentCulture = hrCulture;
CultureInfo.DefaultThreadCurrentUICulture = hrCulture;
app.UseRequestLocalization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// VAŽNO: Autentifikacija mora biti prije autorizacije
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// --- 5. SEEDANJE ULOGA (Stvaranje Admina) ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        await IdentitySeeder.SeedRolesAsync(services);
    }
    catch (Exception ex)
    {
        // Ako nemaš još IdentitySeeder.cs, privremeno zakomentiraj red iznad (stavi // ispred)
    }
}

app.Run();