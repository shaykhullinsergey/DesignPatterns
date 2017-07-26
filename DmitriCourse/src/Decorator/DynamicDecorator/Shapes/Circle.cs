namespace DynamicDecorator
{
  public class Circle : IShape
  {
    private float radius;

    public Circle(float radius)
    {
      this.radius = radius;
    }

    public void Resize(float factor)
    {
      radius *= factor;
    }

    public string Display()
    {
      return $"A circle with radius {radius}";
    }
  }
}
