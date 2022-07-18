using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/home/login");
var app = builder.Build();
app.UseAuthentication();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
