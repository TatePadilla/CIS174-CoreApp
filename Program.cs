using CIS174_CoreApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core dependency injection, allowing the DbContext objects to be properly passed to controllers.
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext")));

// Making URL's lowercase and end with a trailing slash.
builder.Services.AddRouting(options => {
    options.LowercaseUrls = true; options.AppendTrailingSlash = true;
});
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

// Creating route named "student" using the Student controller and ViewStudents action.
app.MapControllerRoute(
    name: "student",
    pattern: "student/viewstudents/{accessLevel:int}",
    defaults: new { controller = "Student", action = "ViewStudents" });

// Default route for index.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
