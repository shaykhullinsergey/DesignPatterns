using System;

namespace DynamicDecorator
{
  public class TransparentShape : IShape
  {
    private IShape shape;
    private float transparency;

    public TransparentShape(IShape shape, float transparency)
    {
      this.shape = shape ?? throw new ArgumentNullException(nameof(shape));
      this.transparency = transparency;
    }

    public string Display()
    {
      return $"{shape.Display()} has the {transparency}% transparency";
    }
  }
}
