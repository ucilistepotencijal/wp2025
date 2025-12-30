using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
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
.AddRoles<IdentityRole>() // Omogu?uje uloge (npr. Admin)
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

// --- 4. KONFIGURACIJA PIPELINE-A (MIDDLEWARE) ---
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Postavljanje HR kulture za datume, brojeve i kalendare
CultureInfo.DefaultThreadCurrentCulture = hrCulture;
CultureInfo.DefaultThreadCurrentUICulture = hrCulture;
app.UseRequestLocalization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Autentifikacija i Autorizacija
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

// --- 5. AUTOMATSKO PUNJENJE BAZE (SEEDING) ---
// Koristimo jedan blok za uloge i za tvoje po?etne usluge
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        // 1. Poku�aj seedanja uloga (Admin, Korisnik) - asinkrono
        await IdentitySeeder.SeedRolesAsync(services);

        // 2. Poku�aj seedanja tvojih usluga (No?enje, Kupanje...) - sinkrono
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        // Ispis gre�ke u Output prozor ako ne�to po?e po zlu
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Dogodila se gre�ka prilikom inicijalizacije baze podataka.");
    }
}

app.Run();