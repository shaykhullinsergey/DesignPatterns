namespace LiskovSubstitution
{
  public class Square : Rectangle
  {
    public override int Width
    {
      set => base.Width = base.Heigth = value;
    }

    public override int Heigth
    {
      set => base.Heigth = base.Width = value;
    }
  }
}
