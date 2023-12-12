using Microsoft.EntityFrameworkCore;
using TrueMetalAppWeb.Data;
using TrueMetalAppWeb.Services;
using TrueMetalAppWeb.Services.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages(options => {
    options.Conventions.AuthorizeFolder("/Generos");
});

builder.Services.AddTransient<IPatchService, PatchService>();
builder.Services.AddDbContext<DistroDbContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DistroDbContext>();


builder.Services.Configure<IdentityOptions>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    // Lockout settings
    options.Lockout.MaxFailedAccessAttempts = 30;
    options.Lockout.AllowedForNewUsers = true;
    // User settings
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

var context = new DistroDbContext();
context.Database.Migrate();

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.UseStaticFiles();

app.Run();
