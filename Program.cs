using Microsoft.EntityFrameworkCore;
using Quercus.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TreeContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("TreeContextSqlite")));

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
    name: "admin_route_ctl",
    pattern: "{area:exists}/{controller}/{action}"
);
app.MapDefaultControllerRoute();


app.Run();
