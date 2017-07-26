using System;

namespace StandardBridge
{
  public class RasterRenderer : IRenderer
  {
    public void RenderCircle(float radius)
    {
      Console.WriteLine($"Drawing pixels for circle with radius {radius}");
    }
  }
}
