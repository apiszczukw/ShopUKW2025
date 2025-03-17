using Microsoft.EntityFrameworkCore;
using ShopUKW2025.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FilmsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));




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

app.MapControllerRoute(
	name: "Categories",
	pattern: "{categoryName}",
	defaults: new { controller = "Films", action = "ProductList" }
	);
app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{siteName}",
    defaults: new { controller = "Home", action = "FooterSites" }
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
