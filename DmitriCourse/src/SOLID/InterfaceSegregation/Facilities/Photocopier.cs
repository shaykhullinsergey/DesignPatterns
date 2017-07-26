namespace InterfaceSegregation
{
  public class Photocopier : IScanner, IPrinter
  {
    public void Print(Document doc)
    {
    }

    public void Scan(Document doc)
    {
    }
  }
}
