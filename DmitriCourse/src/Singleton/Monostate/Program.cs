using System;

namespace Monostate
{
  class Program
  {
    static void Main(string[] args)
    {
      var ceo = new CEO
      {
        Name = "Adam Smith",
        Age = 55
      };

      var ceo2 = new CEO();
      Console.WriteLine(ceo2);
    }
  }
}
