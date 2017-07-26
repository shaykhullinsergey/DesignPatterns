using System;

namespace DynamicDecorator
{
  class Program
  {
    static void Main(string[] args)
    {
      var sq = new Square(123);
      Console.WriteLine(sq.Display());

      var redSquare = new ColoredShape(sq, "red");
      Console.WriteLine(redSquare.Display());

      var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);

      Console.WriteLine(redHalfTransparentSquare.Display());
    }
  }
}
