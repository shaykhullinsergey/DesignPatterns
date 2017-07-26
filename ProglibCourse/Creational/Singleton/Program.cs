using System;

namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      var president1 = President.Instance;
      var president2 = President.Instance;

      Console.WriteLine(ReferenceEquals(president1, president2));
    }
  }

  public sealed class President
  {
    private static President instance;

    public static President Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new President();
        }

        return instance;
      }
    }

    private President()
    {
        
    }
  }
}
