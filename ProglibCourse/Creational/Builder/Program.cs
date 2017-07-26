using System;

namespace Builder
{
  class Program
  {
    static void Main(string[] args)
    {
      var burger = new BurgerBuilder(10)
        .AddCheese()
        .AddLettuce()
        .AddPepperoni()
        .AddTomato()
        .Build();

    }
  }

  public class Burger
  {
    private int size;

    private bool cheese;
    private bool pepperoni;
    private bool lettuce;
    private bool tomato;

    public Burger(BurgerBuilder builder)
    {
      size = builder.Size;
      cheese = builder.Cheese;
      pepperoni = builder.Pepperoni;
      lettuce = builder.Lettuce;
      tomato = builder.Tomato;
    }
  }

  public class BurgerBuilder
  {
    public int Size { get; private set; }
    public bool Cheese { get; private set; }
    public bool Pepperoni { get; private set; }
    public bool Lettuce { get; private set; }
    public bool Tomato { get; private set; }

    public BurgerBuilder(int size)
    {
      this.Size = size;
    }

    public BurgerBuilder AddCheese()
    {
      Cheese = true;
      return this;
    }

    public BurgerBuilder AddPepperoni()
    {
      Pepperoni = true;
      return this;
    }

    public BurgerBuilder AddLettuce()
    {
      Lettuce = true;
      return this;
    }

    public BurgerBuilder AddTomato()
    {
      Tomato = true;
      return this;
    }

    public Burger Build()
    {
      return new Burger(this);
    }
  }
}
