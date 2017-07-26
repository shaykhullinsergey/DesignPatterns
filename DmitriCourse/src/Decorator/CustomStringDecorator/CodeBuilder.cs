using System.Text;

namespace CustomStringDecorator
{
  public class CodeBuilder
  {
    private StringBuilder builder = new StringBuilder();

    public CodeBuilder Append(string str)
    {
      builder.Append(str);
      return this;
    }

    public CodeBuilder AppendLine(string str)
    {
      builder.AppendLine(str);
      return this;
    }

    public CodeBuilder AppendFormat(string format, params string[] args)
    {
      builder.AppendFormat(format, args);
      return this;
    }

    public CodeBuilder AppendFormatLine(string format, params string[] args)
    {
      builder.AppendFormat(format, args)
        .AppendLine();
      return this;
    }

    public override string ToString()
    {
      return builder.ToString();
    }
  }
}
