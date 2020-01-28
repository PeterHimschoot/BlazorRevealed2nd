using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Services
{
  public class MenuService : IMenuService
  {
    private readonly HttpClient httpClient;

    public MenuService(HttpClient httpClient)
      => this.httpClient = httpClient;


    public async Task<Menu> GetMenu()
    {
      Pizza[] pizzas = await this.httpClient.GetJsonAsync<Pizza[]>("/pizzas");
      return new Menu { Pizzas = pizzas.ToList() };
    }
  }
}
