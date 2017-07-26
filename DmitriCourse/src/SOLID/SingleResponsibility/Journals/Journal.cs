using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
  //Keep entries
  public class Journal
  {
    private static int count = 0;
    private readonly List<string> entries = new List<string>();

    public int AddEntry(string text)
    {
      entries.Add($"{++count}: {text}");
      return count;
    }

    public void RemoveEntry(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }
  }
}
