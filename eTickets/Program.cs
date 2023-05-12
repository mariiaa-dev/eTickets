using eTickets.Application.DependencyInjections;
using eTickets.Extensions.Middleware.UnhandledExceptions.Extensions;
using eTickets.Initializer.DependencyInjections;
using eTickets.Mapping;
using eTickets.Persistence.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var path = Directory.GetCurrentDirectory() + "\\" + "appsettings.json";
builder.Services.AddPersistence(path);

builder.Services.AddServices();
builder.Services.Initialize();

builder.Services.AddAutoMapper(typeof(DomainModelToViewModelProfile));
builder.Services.AddAutoMapper(typeof(ViewModelToDomainModelProfile));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Shared/NotFound");
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