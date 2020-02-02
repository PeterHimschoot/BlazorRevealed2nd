using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MyFirstBlazor.Client.Services;
using System.Threading.Tasks;

namespace MyFirstBlazor.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);

      builder.Services.AddSingleton<ILocalStorage, LocalStorage>();

      builder.RootComponents.Add<App>("app");

      await builder.Build().RunAsync();
    }
  }
}
