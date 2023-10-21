using BusinessLayer;
using BusinessLayer.AutoFac;
using DataLayer;
using ElmahCore.Mvc;
using ElmahCore.Sql;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLocalization(op =>
{
    op.ResourcesPath = "Resources";
}
);
// Add services to the container.
builder.Services.AddControllersWithViews()
    //.SetCompatibilityVersion(CompatibilityVersion.Latest)
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
    op => { op.ResourcesPath = "Resources"; });

builder.Services.ConfigureDataLayerRegistration(builder.Configuration);
builder.Services.ConfigureBusinessLayerServices();
builder.Services.BuildAutofacServiceProvider();

builder.Services.AddElmah<SqlErrorLog>(op =>
{
    op.LogPath = "/Elmah";
    op.ConnectionString = builder.Configuration.GetConnectionString("MurenoClockConnection");
});

//builder.Services.AddDbContext<MurenoClockContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddRazorPages();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MurenoClockContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseHttpsRedirection();
app.UseElmah();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
/// localization
/// 
var supportedCultures = new List<CultureInfo>()
            {
                new CultureInfo("fa-IR"),
                new CultureInfo("en-US")
            };
var options = new RequestLocalizationOptions()
{
    DefaultRequestCulture = new RequestCulture("fa-IR"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures,
    RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
};
app.UseRequestLocalization(options);

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
