using System;

namespace CustomStringDecorator
{
  class Program
  {
    static void Main(string[] args)
    {
      var cb = new CodeBuilder()
        .Append("First")
        .AppendLine("Second")
        .AppendFormat("{0}", "Third")
        .AppendFormatLine("{0}", "Fourth");

      Console.WriteLine(cb);
    }
  }
}
