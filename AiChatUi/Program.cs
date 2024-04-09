using AiChatUi.Components;
using AiChatUi.Services;
using Blazored.LocalStorage;
using Claudia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// get ANTHROPIC_API_KEY from user secret
// https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets
Environment.SetEnvironmentVariable("ANTHROPIC_API_KEY", builder.Configuration["ANTHROPIC_API_KEY"]);

// Add Anthropic Client
builder.Services.AddSingleton<AnthropicFactory>();
builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();