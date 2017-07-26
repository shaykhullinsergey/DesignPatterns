using System;

namespace SimpleFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      var door = DoorFactory.MakeWoodenDoor(100, 100);

      Console.WriteLine(door.Width);
      Console.WriteLine(door.Heigth);
    }
  }

  public interface IDoor
  {
    float Width { get; }
    float Heigth { get; }
  }

  public class WoodenDoor : IDoor
  {
    public float Width { get; private set; }
    public float Heigth { get; private set; }

    public WoodenDoor(float width, float heigth)
    {
      this.Width = width;
      this.Heigth = heigth;
    }
  }

  public class DoorFactory
  {
    public static IDoor MakeWoodenDoor(float width, float height)
    {
      return new WoodenDoor(width, height);
    }  
  }
}
