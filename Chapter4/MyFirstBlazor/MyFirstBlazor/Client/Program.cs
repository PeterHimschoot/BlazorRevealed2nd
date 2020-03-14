using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MyFirstBlazor.Client;
using MyFirstBlazor.Client.Services;
using MyFirstBlazor.Shared;
using System.Threading.Tasks;

namespace MyFirstBlazor.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);

      builder.Services.AddSingleton<IProductsService, HardCodedProductService>();

      builder.Services.AddBaseAddressHttpClient();

      builder.RootComponents.Add<App>("app");
      await builder.Build().RunAsync();
    }
  }
}
