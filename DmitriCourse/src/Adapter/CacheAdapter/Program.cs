using System;
using System.Collections.Generic;

namespace DotNetDesignPatternDemos.Structural.Adapter.WithCaching
{
  public class Program
  {
    private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
      new VectorRectangle(1, 1, 10, 10),
      new VectorRectangle(3, 3, 6, 6)
    };

    public static void DrawPoint(Point p)
    {
      Console.Write(".");
    }

    static void Main(string[] args)
    {
      Draw();
      Draw();
    }

    private static void Draw()
    {
      foreach (var vo in vectorObjects)
      {
        foreach (var line in vo)
        {
          var adapter = new LineToPointAdapter(line);
          foreach (var a in adapter)
          {
            DrawPoint(a);
          }
        }
      }
    }
  }
}