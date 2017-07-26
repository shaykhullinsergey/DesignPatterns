using System;

namespace AdapterDecorator
{
  class Program
  {
    static void Main(string[] args)
    {
      var str = (MyStringBuilder)"hello ";
      str += "world";
      str += "!";

      Console.WriteLine(str);
    }
  }
}
