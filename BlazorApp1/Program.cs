using BlazorApp1.Data;
using BlazorApp1.Logic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddSingleton<IValues, Values>(); // same values for the whole lifecycle
//builder.Services.AddScoped<IValues, Values>();  // same values until refresh, after changing page and coming back, same values. each have copy of singleton. not keeping one instance ine memory forever like singleton, but releases resources
//builder.Services.AddTransient<IValues, Values>(); // same values until refresh, after changing page and coming back, new values. new instance every time you asked for it
builder.Services.AddScoped<IValues, BetterValues>(); // changing to bettervalues with different logic in only one place. And if I want to comeback to previous logic, just change to "Values", interface always stays the same and that's beautiful
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
