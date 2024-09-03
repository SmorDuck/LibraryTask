using LibraryTaskFront.Components;
using LibraryTaskFront.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<LibraryServices>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7007/");
});
builder.Services.AddRazorPages();
builder.Services.AddRazorPages();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();