namespace DynamicDecorator
{
  public class Square : IShape
  {
    private float side;

    public Square(float side)
    {
      this.side = side;
    }

    public void Resize(float factor)
    {
      side *= factor;
    }

    public string Display()
    {
      return $"A square with side {side}";
    }
  }
}
