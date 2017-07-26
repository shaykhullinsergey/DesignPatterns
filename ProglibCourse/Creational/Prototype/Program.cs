using System;

namespace Prototype
{
  class Program
  {
    static void Main(string[] args)
    {
      var original = new Sheep("Dolly");
      var clone = original.Clone();
      clone.Name = "Dolly2";

      Console.WriteLine(original.Name);
      Console.WriteLine(clone.Name);
    }
  }

  public class Sheep
  {
    public string Name { get; set; }
    public string Category { get; set; }

    public Sheep(string name, string category = "Sheep")
    {
      this.Name = name;
      this.Category = category;
    }

    public Sheep Clone()
    {
      return new Sheep(Name, Category);
    }
  }
}
