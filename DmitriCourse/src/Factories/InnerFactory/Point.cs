using System;

namespace FactoryMethod
{
  public class Point
  {
    public static PointFactory Factory { get; } = new PointFactory();

    private double x, y;

    private Point(double x, double y)
    {
      this.x = x;
      this.y = y;
    }

    public override string ToString()
    {
      return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }

    public class PointFactory
    {
      public Point Origin { get; } = new Point(0, 0);

      public Point NewCartesianPoint(double x, double y)
      {
        return new Point(x, y);
      }

      public Point NewPolarPoint(double rho, double theta)
      {
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
      }
    }
  }
}
