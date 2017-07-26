namespace StandardBridge
{
  public abstract class Shape
  {
    protected IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
      this.renderer = renderer;
    }

    public abstract void Draw();
    public abstract void Resize(float factor);
  }
}
