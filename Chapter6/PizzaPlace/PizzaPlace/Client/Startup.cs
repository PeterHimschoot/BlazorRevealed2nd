using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlace.Client.Services;
using PizzaPlace.Shared;

namespace PizzaPlace.Client
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddTransient<IMenuService, MenuService>();
      services.AddTransient<IOrderService, ConsoleOrderService>();
    }

    public void Configure(IComponentsApplicationBuilder app) 
      => app.AddComponent<App>("app");
  }
}
