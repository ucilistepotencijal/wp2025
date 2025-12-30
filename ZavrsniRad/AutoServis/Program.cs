using AutoServis.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var hrCulture = new CultureInfo("hr-HR");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(hrCulture);
    options.SupportedCultures = new[] { hrCulture };
    options.SupportedUICultures = new[] { hrCulture };
});

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

var culture = new CultureInfo("hr-HR");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

var locOptions = app.Services.GetRequiredService<
    Microsoft.Extensions.Options.IOptions<RequestLocalizationOptions>>();

app.UseRequestLocalization(locOptions.Value);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Authentication must come before Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

// Seed roles in a scope and await the async call
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await IdentitySeeder.SeedRolesAsync(services);
}

app.Run();
