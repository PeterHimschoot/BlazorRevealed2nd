using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyFirstBlazor.Shared;
using MyFirstBlazor.Client.Services;

namespace MyFirstBlazor.Client
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton<IProductsService, HardCodedProductService>();
    }

    public void Configure(IComponentsApplicationBuilder app) 
      => app.AddComponent<App>("app");
  }
}
