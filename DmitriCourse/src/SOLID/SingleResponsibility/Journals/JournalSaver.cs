using System;
using System.IO;

namespace SingleResponsibility
{
  //Save entries
  public class JournalSaver
  {
    public void SaveToFile(string path, Journal journal, bool overwrite = false)
    {
      if(overwrite || !File.Exists(path))
      {
        File.WriteAllText(path, journal.ToString());
      }
    }

    public Journal LoadFromFile(string path)
    {
      throw new NotImplementedException();
    }
  }
}
