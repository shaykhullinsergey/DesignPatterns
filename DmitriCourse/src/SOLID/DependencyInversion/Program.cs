using System;

namespace DependencyInversion
{
  class Program
  {
    static void Main(string[] args)
    {
      var parent = new Person { Name = "John" };
      var child1 = new Person { Name = "Chris" };
      var child2 = new Person { Name = "Mary" };

      var relationships = new Relationships();
      relationships.AddParentAndChild(parent, child1);
      relationships.AddParentAndChild(parent, child2);

      foreach (var children in relationships.FindAllChildrenOf("John"))
      {
        Console.WriteLine(children.Name);
      }
    }
  }
}
