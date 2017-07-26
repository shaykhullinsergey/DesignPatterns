using System;

namespace AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      var woodenFactory  = new WoodenDoorFactory();
      var woodenDoor = woodenFactory.MakeDoor();
      var woodenExpert = woodenFactory.MakeExpert();

      var ironFactory  = new IronDoorFactory();
      var ironDoor = woodenFactory.MakeDoor();
      var ironExpert = woodenFactory.MakeExpert();
    }
  }

  public interface IDoor
  {
    string Description { get; }
  }

  public class WoodenDoor : IDoor
  {
    public string Description => "Wooden door";
  }

  public class IronDoor : IDoor
  {
    public string Description => "Iron door";
  }

  public interface IDoorExpert
  {
    string Description { get; }  
  }

  public class Carpenter : IDoorExpert
  {
    public string Description => "Wooden doors only!";
  }

  public class Welder : IDoorExpert
  {
    public string Description => "Idor doors only!";
  }

  public interface IDoorFactory
  {
    IDoor MakeDoor();
    IDoorExpert MakeExpert();
  }

  public class WoodenDoorFactory : IDoorFactory
  {
    public IDoor MakeDoor()
    {
      return new WoodenDoor();
    }

    public IDoorExpert MakeExpert()
    {
      return new Carpenter();
    }
  }

  public class IronDoorFactory : IDoorFactory
  {
    public IDoor MakeDoor()
    {
      return new IronDoor();
    }

    public IDoorExpert MakeExpert()
    {
      return new Welder();
    }
  }
}
