using System;

namespace StandardBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      var builder = new HtmlBuilder("ul")
        .AddChild("li", "Hello")
        .AddChild("li", "World")
        .AddChild("li", "!");

      Console.WriteLine(builder);
    }
  }
}
