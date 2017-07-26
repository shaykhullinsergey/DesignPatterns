using System;

namespace FactoryMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      var cartesian = Point.NewCartesianPoint(0, 1);
      Console.WriteLine(cartesian);

      var polar = Point.NewPolarPoint(1.0, Math.PI / 2);
      Console.WriteLine(polar);
    }
  }
}
