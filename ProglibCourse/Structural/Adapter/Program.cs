using System;

namespace Adapter
{
  class Program
  {
    static void Main(string[] args)
    {
      var dog = new WildDog();
      var adapter = new WildDogAdapter(dog);
      
      var hunter = new Hunter();
      hunter.Hunt(adapter);
    }
  }

  public interface ILion
  {
    void Roar();
  }

  public class AfricanLion : ILion
  {
    public void Roar()
    {
    }
  }

  public class AsianLion : ILion
  {
    public void Roar()
    {
    }
  }

  public class Hunter
  {
    public void Hunt(ILion lion)
    {
    }
  }

  public class WildDog
  {
    public void Bark()
    {
    }
  }

  public class WildDogAdapter : ILion
  {
    private WildDog dog;

    public WildDogAdapter(WildDog dog)
    {
      this.dog = dog;
    }

    public void Roar()
    {
      dog.Bark();
    }
  }
}
