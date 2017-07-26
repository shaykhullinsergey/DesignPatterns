using System;
using System.Diagnostics;
using System.IO;

namespace SingleResponsibility
{
  class Program
  {
    static void Main(string[] args)
    {
      var journal = new Journal();
      journal.AddEntry("I cried today");
      journal.AddEntry("I ate a bug");

      Console.WriteLine(journal);

      var saver = new JournalSaver();
      var filename = Path.Combine(Environment.CurrentDirectory, "journal.txt");
      saver.SaveToFile(filename, journal, true);

      Process.Start("explorer", filename);
    }
  }
}
