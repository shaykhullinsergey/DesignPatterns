using System;

namespace LiskovSubstitution
{
  class Program
  {
    static int Area(Rectangle rc) => rc.Width * rc.Heigth;

    static void Main(string[] args)
    {
      Rectangle rc = new Rectangle(2, 3);
      Console.WriteLine($"{rc} has area {Area(rc)}");

      Rectangle sq = new Square
      {
        Width = 4
      };
      Console.WriteLine($"{sq} has area {Area(sq)}");
    }
  }
}
