using System;

namespace OpenClosed
{
  class Program
  {
    static void Main(string[] args)
    {
      var apple = new Product("Apple", Color.Green, Size.Small);
      var tree = new Product("Tree", Color.Green, Size.Large);
      var house = new Product("House", Color.Blue, Size.Large);

      var products = new[] { apple, tree, house };

      var filter = new ProductFilter();
      foreach (var product in filter.Filter(products, new ColorSpecification(Color.Green)))
      {
        Console.WriteLine($" - {product.Name} is Green");
      }

      Console.WriteLine();

      foreach (var product in filter.Filter(products, new SizeSpecification(Size.Small)))
      {
        Console.WriteLine($" - {product.Name} is Small");
      }

      Console.WriteLine();

      foreach (var product in filter.Filter(products, new AndSpecification<Product>
        (new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
      {
        Console.WriteLine($" - {product.Name} is Large and Blue");
      }
    }
  }
}
