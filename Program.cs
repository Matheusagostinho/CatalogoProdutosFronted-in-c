using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CatalogoFrontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Aqui tem que colocar o endereco da API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7092") });

await builder.Build().RunAsync();
