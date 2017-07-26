using System;

namespace AbstractFactory
{
  internal class CoffeeFactory : IHotDrinkFactory
  {
    public IHotDrink Prepare(int amount)
    {
      Console.WriteLine($"Grind some eans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
      return new Coffee();
    }
  }
}
