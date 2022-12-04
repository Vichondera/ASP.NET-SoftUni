using All4Auto.Core.Constants;
using All4Auto.DataProcessor;
using All4Auto.DataProcessor.Models.Account;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<All4AutoDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<UserProfile>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
    options.User.RequireUniqueEmail = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<All4AutoDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CanDeleteProduct", policy =>
        policy.RequireAssertion(context =>
        context.User.IsInRole(RoleConstants.Owner) && context.User.IsInRole(RoleConstants.Administrator)));
});

builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IVehicleService, VehicleService>();
//builder.Services.AddScoped<IRepository, Repository>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
         name: "Garage",
         areaName: "Garage",
         pattern: "Garage/{controller=Home}/{action=Index}"
     );

    endpoints.MapControllerRoute(
        name: "areaRoute",
        pattern: "{area:exists}/{controller}/{action}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapRazorPages();

app.Run();
