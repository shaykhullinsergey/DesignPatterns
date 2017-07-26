namespace StandardBuilder
{
  public class HtmlBuilder
  {
    private HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
      root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
      var element = new HtmlElement(childName, childText);
      root.Elements.Add(element);
      return this;
    }

    public void Clear()
    {
      root = new HtmlElement(root.Name);
    }

    public override string ToString()
    {
      return root.ToString();
    }
  }
}
