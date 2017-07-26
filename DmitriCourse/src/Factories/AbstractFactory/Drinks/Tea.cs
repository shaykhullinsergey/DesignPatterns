using System;

namespace AbstractFactory
{
  internal class Tea : IHotDrink
  {
    public void Consume()
    {
      Console.WriteLine("This tea is nice but i'd prefer it with milk");
    }
  }
}
