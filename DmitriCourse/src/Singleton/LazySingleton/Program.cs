using System;
using System.Linq;

namespace LazySingleton
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = SingletonDatabase.Instance;
      Console.WriteLine(db.GetPopulation("Tokyo"));
    }
  }
}
