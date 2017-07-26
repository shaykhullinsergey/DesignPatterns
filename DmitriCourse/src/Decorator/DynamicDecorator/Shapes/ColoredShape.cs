using System;

namespace DynamicDecorator
{
  public class ColoredShape : IShape
  {
    private IShape shape;
    private string color;

    public ColoredShape(IShape shape, string color)
    {
      this.shape = shape ?? throw new ArgumentNullException(nameof(shape));
      this.color = color ?? throw new ArgumentNullException(nameof(color));
    }

    public string Display()
    {
      return $"{shape.Display()} has the color {color}";
    }
  }
}
