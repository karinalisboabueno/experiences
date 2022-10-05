using GestorDeTempos;
using GestorDeTempos.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//esta linha foi adicionada: (e também o namespace Equipas.Data) <---------------------------------
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer(
                        builder.Configuration.GetConnectionString("DefaultConnection")));

//BASICAUTHORIZE (2022-07-16) - para a proteção de classes / métodos ------------------------------ C
//configura para autenticação: <------------------ 
builder.Services.AddAuthentication()
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
    ("BasicAuthentication", OptionsBuilderConfigurationExtensions => { });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("BasicAuthentication", new AuthorizationPolicyBuilder("BasicAuthentication")
        .RequireAuthenticatedUser().Build());
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();//incluida
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
