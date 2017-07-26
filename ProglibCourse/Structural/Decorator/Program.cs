using System;

namespace Decorator
{
  class Program
  {
    static void Main(string[] args)
    {
      var simple = new SimpleCoffee();
      var milk = new MilkCoffee(simple);
      var whip = new WhipCoffee(milk);
      var vanilla = new VanillaCoffee(whip);

      var cost = vanilla.Cost;
      var description = vanilla.Description;
    }
  }

  public interface ICoffee
  {
    int Cost{ get; }
    string Description{ get; }
  }

  public class SimpleCoffee : ICoffee
  {
    public int Cost => 10;
    public string Description => "Simple Coffee";
  }

  public class MilkCoffee : ICoffee
  {
    private ICoffee coffee;

    public int Cost => coffee.Cost + 2;
    public string Description => coffee.Description + ", Milk";

    public MilkCoffee(ICoffee coffee)
    {
      this.coffee = coffee;
    }
  }

  public class WhipCoffee : ICoffee
  {
    private ICoffee coffee;

    public int Cost => coffee.Cost + 5;
    public string Description => coffee.Description + ", Whip";

    public WhipCoffee(ICoffee coffee)
    {
      this.coffee = coffee;
    }
  }

  public class VanillaCoffee : ICoffee
  {
    private ICoffee coffee;
      
    public int Cost => coffee.Cost + 3;
    public string Description => coffee.Description + ", Vanilla";

    public VanillaCoffee(ICoffee coffee)
    {
      this.coffee = coffee;
    }
  }
}
