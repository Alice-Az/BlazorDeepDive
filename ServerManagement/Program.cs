using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ServerManagement.Components;
using ServerManagement.StateStore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<TorontoOnlineServersStore>();
builder.Services.AddScoped<MontrealOnlineServersStore>();
builder.Services.AddScoped<OttawaOnlineServersStore>();
builder.Services.AddScoped<CalgaryOnlineServersStore>();
builder.Services.AddScoped<HalifaxOnlineServersStore>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();