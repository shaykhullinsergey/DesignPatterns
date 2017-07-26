using System;
using System.Collections.Generic;
using System.Threading;

namespace AbstractFactory
{
  public class HotDrinkMachine
  {
    private List<(string Name, IHotDrinkFactory Type)> factories = new List<(string, IHotDrinkFactory)>();

    public HotDrinkMachine()
    {
      foreach (var type in typeof(HotDrinkMachine).Assembly.GetTypes())
      {
        if(typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
        {
          factories.Add
          (
            (type.Name.Replace("Factory", ""), (IHotDrinkFactory)Activator.CreateInstance(type))
          );
        }
      }
    }

    public IHotDrink MakeDrink()
    {
      while (true)
      {
        Console.WriteLine("Drinks:");
        for (int i = 0; i < factories.Count; i++)
        {
          Console.WriteLine($"{i}: {factories[i].Name}");
        }

        var (factorySucceed, index) = CheckFactoryInput();
        
        if(factorySucceed)
        {
          Console.WriteLine("Amount:");
          var (amountSucceed, amount) = CheckAmountInput();

          if(amountSucceed)
          {
            return factories[index].Type.Prepare(amount);
          }
        }

        Console.WriteLine("Incorrect input, try again!");
        Thread.Sleep(1000);
        Console.Clear();
      }

      (bool, int) CheckFactoryInput()
      {
        string input;
        if ((input = Console.ReadLine()) != null && int.TryParse(input, out var factory) && factory >= 0 && factory < factories.Count)
        {
          return (true, factory);
        }
        return (false, 0);
      }

      (bool, int) CheckAmountInput()
      {
        string input;
        if ((input = Console.ReadLine()) != null && int.TryParse(input, out var amount) && amount >= 0)
        {
          return (true, amount);
        }
        return (false, 0);
      }
    }
  }
}
