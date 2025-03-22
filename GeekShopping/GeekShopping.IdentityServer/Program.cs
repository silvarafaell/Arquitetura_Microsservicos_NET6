using Duende.IdentityServer.Services;
using GeekShopping.IdentityServer.Configuration;
using GeekShopping.IdentityServer.Model;
using GeekShopping.IdentityServer.Model.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySqlConnection:MysqlConnectionString"];

builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 0))));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<MySQLContext>()
    .AddDefaultTokenProviders();

var builderr = builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;
    options.EmitStaticAudienceClaim = true;
}).AddInMemoryIdentityResources(
                       IdentityConfiguration.IdentityResources)
                   .AddInMemoryApiScopes(IdentityConfiguration.ApiScopes)
                   .AddInMemoryClients(IdentityConfiguration.Clients)
                   .AddAspNetIdentity<ApplicationUser>();

builderr.AddDeveloperSigningCredential();

// Adiciona a compilação em tempo de execução (somente no ambiente de desenvolvimento)
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddControllersWithViews()
        .AddRazorRuntimeCompilation();
}
else
{
    builder.Services.AddControllersWithViews();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
