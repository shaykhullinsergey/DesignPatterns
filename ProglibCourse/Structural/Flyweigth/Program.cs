using System;
using System.Collections.Generic;

namespace Flyweigth
{
  class Program
  {
    static void Main(string[] args)
    {
      var maker = new TeaMaker();
      var shop = new TeaShop(maker);

      shop.Order("Simple", 1);
      shop.Order("Milk", 2);
      shop.Order("Milk", 3);
      shop.Order("Simple", 4);

      shop.Serve();
    }
  }

  public class Tea
  {
  }

  public class TeaMaker
  {
    private Dictionary<string, Tea> avaliableTea = new Dictionary<string, Tea>();

    public Tea Make(string preference)
    {
      if(avaliableTea.TryGetValue(preference, out var tea))
      {
        return tea;
      }
      
      tea = new Tea();
      avaliableTea.Add(preference, tea);

      return tea;
    } 
  }

  public class TeaShop
  {
    private Dictionary<int, Tea> orders = new Dictionary<int, Tea>();
    private TeaMaker maker;

    public TeaShop(TeaMaker maker)
    {
      this.maker = maker;  
    }

    public void Order(string preference, int table)
    {
      orders.Add(table, maker.Make(preference));
    }

    public void Serve()
    {
      foreach (var order in orders)
      {
        Console.WriteLine($"Serving tea, table {order.Key}");
      }
    }
  }
}
