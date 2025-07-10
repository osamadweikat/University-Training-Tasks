using Brands_Shope;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<CartService>();

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7123/") });
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddScoped<OrderService>();


await builder.Build().RunAsync();
