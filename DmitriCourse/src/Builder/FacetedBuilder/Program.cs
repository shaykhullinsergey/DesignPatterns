using System;

namespace FacetedBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      var person = new PersonBuilder()
        .Works.At("Fabrikam")
          .AsA("Engineer")
          .Earning(12)
        .Lives.At("123 London road")
          .In("London")
          .WithPostcode("SQ12AC")
        .Build();

      Console.WriteLine(person);
    }
  }
}
