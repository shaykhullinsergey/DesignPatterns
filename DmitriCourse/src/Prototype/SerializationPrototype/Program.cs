using System;

namespace SerializationPrototype
{
  class Program
  {
    static void Main(string[] args)
    {
      var john = new Person(new[] { "John", "Smith" }, new Address("London road", 123));

      var jane = john.DeepCopy();
      jane.Names[0] = "Jane";
      jane.Address.HouseNumber = 312;

      var jill = jane.DeepCopyXml();
      jill.Names[0] = "Jill";
      jill.Address.HouseNumber = 321;

      Console.WriteLine(john);
      Console.WriteLine(jane);
      Console.WriteLine(jill);
    }
  }
}
