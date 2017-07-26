using System.Collections.Generic;
using System.Text;

namespace StandardBuilder
{
  public class HtmlElement
  {
    private const int indentSize = 2;
    public string Name, Text;
    public List<HtmlElement> Elements = new List<HtmlElement>();

    public HtmlElement()
    {
    }

    public HtmlElement(string name, string text = "")
    {
      Name = name;
      Text = text;
    }

    private string ToStringImpl(int indent)
    {
      var sb = new StringBuilder();
      sb.AppendLine($"{Indentation(indent)}<{Name}>");

      if(!string.IsNullOrWhiteSpace(Text))
      {
        sb.AppendLine($"{Indentation(indent + 1)}{Text}");
      }

      foreach (var element in Elements)
      {
        sb.Append(element.ToStringImpl(indent + 1));
      }

      sb.AppendLine($"{Indentation(indent)}</{Name}>");
      return sb.ToString();

      string Indentation(int i)
      {
        return new string(' ', indentSize * i);
      }
    }

    public override string ToString()
    {
      return ToStringImpl(0);
    }
  }
}
