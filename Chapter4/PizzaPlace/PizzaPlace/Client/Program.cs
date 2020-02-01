using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlace.Shared;
using System.Threading.Tasks;

namespace PizzaPlace.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("app");
      builder.Services.AddTransient<IMenuService, HardCodedMenuService>();
      builder.Services.AddTransient<IOrderService, ConsoleOrderService>();
      await builder.Build().RunAsync();
    }
  }
}
