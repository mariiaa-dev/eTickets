using eTickets.Application.DependencyInjections;
using eTickets.Initializer.DependencyInjections;
using eTickets.Persistence.DependencyInjections;
using eTicketsCustomMiddleware.UnhandledExceptions.Extensions;

var builder = WebApplication.CreateBuilder(args);

var path = Directory.GetCurrentDirectory() + "\\" + "appsettings.json";
builder.Services.AddPersistence(path);

builder.Services.AddServices();
builder.Services.Initialize();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseCustomExceptionHandler();

app.UseRouting();  

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();