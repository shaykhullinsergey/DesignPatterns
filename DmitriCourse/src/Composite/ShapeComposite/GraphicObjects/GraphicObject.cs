using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeComposite
{
  public class GraphicObject
  {
    private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();

    public List<GraphicObject> Children => children.Value;
    public virtual string Name { get; set; } = "Group";
    public string Color;

    private void ToString(StringBuilder sb, int depth)
    {
      sb.Append(new string('*', depth))
        .Append(string.IsNullOrWhiteSpace(Color) ? "" : $"{Color} ")
        .AppendLine(Name);

      foreach (var child in Children)
      {
        child.ToString(sb, depth + 1);
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder();
      ToString(sb, 0);
      return sb.ToString();
    }
  }
}
