namespace LiskovSubstitution
{
  public class Rectangle
  {
    public virtual int Width { get; set; }
    public virtual int Heigth { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(int width, int heigth)
    {
      Width = width;
      Heigth = heigth;
    }

    public override string ToString()
    {
      return $"{nameof(Width)}: {Width}, {nameof(Heigth)}: {Heigth}";
    }
  }
}
