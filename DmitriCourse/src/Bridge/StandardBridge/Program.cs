using System.Collections.Generic;

namespace StandardBridge
{
  class Program
  {
    static void Main(string[] args)
    {
      IRenderer renderer = new VectorRenderer();

      var circle = new Circle(renderer, 5);
      circle.Draw();
      circle.Resize(2);
      circle.Draw();
    }
  }
}
