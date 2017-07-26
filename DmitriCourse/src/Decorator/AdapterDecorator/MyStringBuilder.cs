using System.Text;

namespace AdapterDecorator
{
  public class MyStringBuilder
  {
    private StringBuilder builder = new StringBuilder();

    public static implicit operator MyStringBuilder(string str)
    {
      var msb = new MyStringBuilder();
      msb.builder.Append(str);
      return msb;
    }

    public static MyStringBuilder operator + (MyStringBuilder msb, string str)
    {
      msb.builder.Append(str);
      return msb;
    }

    public override string ToString()
    {
      return builder.ToString();
    }
  }
}
