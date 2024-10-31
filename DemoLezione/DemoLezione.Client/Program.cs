using DemoLezione.Business;
using DemoLezione.Client.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IMyInterface, MyClientService>();

await builder.Build().RunAsync();
