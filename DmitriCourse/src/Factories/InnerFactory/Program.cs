using System;

namespace FactoryMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      var cartesian = Point.Factory.NewCartesianPoint(0, 1);
      Console.WriteLine(cartesian);

      var polar = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
      Console.WriteLine(polar);

      var origin = Point.Factory.Origin;
      Console.WriteLine(origin);
    }
  }
}
