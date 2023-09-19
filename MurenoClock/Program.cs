using BusinessLayer;
using DataLayer;
using ElmahCore.Mvc;
using ElmahCore.Sql;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.ConfigureDataLayerRegistration(builder.Configuration);
builder.Services.ConfigureBusinessLayerServices();

builder.Services.AddElmah<SqlErrorLog>(op =>
{

    op.LogPath = "/Elmah";
    op.ConnectionString = builder.Configuration.GetConnectionString("MurenoClockConnection");
    //op.SqlServerDatabaseSchemaName = "Errors";
    //op.SqlServerDatabaseTableName = "ElmahError";


});
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
