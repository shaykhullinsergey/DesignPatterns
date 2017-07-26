using System;
using System.Collections.Generic;
using System.IO;

namespace LazySingleton
{
  public class SingletonDatabase : IDatabase
  {
    private static Lazy<SingletonDatabase> instance = 
      new Lazy<SingletonDatabase>(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;

    private Dictionary<string, int> capitals = new Dictionary<string, int>();

    private SingletonDatabase()
    {
      var lines = File.ReadAllLines("capitals.txt");

      for (int i = 0; i < lines.Length; i += 2)
      {
        capitals.Add(lines[i], int.Parse(lines[i + 1]));
      }
    }

    public int GetPopulation(string capital)
    {
      return capitals[capital];
    }
  }
}
