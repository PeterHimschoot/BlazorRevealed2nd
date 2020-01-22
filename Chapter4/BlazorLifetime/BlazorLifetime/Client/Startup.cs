using BlazorLifetime.Shared;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorLifetime.Client
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
      => services.AddLifetime();

    public void Configure(IComponentsApplicationBuilder app)
      => app.AddComponent<App>("app");
  }
}
