using BlazingPizzaApp.Shared;
using BlazingPizzaApp.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Register server-side services
builder.Services.AddSingleton<PizzaService>();
builder.Services.AddSingleton<OrderService>();

var app = builder.Build();

// Middleware
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
