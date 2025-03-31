using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEaseApp;
using EventEaseApp.Services;
using EventEaseApp.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(typeof(IStateService<Event>), typeof(StateService<Event>));
builder.Services.AddScoped(typeof(IStateService<Attender>), typeof(StateService<Attender>));

builder.Services.AddScoped<EventsService>();
builder.Services.AddScoped<AttendanceService>();

builder.Services.AddLogging();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
