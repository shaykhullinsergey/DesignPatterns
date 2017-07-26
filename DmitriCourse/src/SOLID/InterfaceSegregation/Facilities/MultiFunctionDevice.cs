namespace InterfaceSegregation
{
  public class MultiFunctionDevice : IMultiFunctionDevice
  {
    private IPrinter printer;
    private IScanner scanner;

    public MultiFunctionDevice(IPrinter printer, IScanner scanner)
    {
      this.printer = printer;
      this.scanner = scanner;
    }

    public void Fax(Document doc)
    {
      //...
    }

    public void Print(Document doc)
    {
      printer.Print(doc);
    }

    public void Scan(Document doc)
    {
      scanner.Scan(doc);
    }
  }
}
