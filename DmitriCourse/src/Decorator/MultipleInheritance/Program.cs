namespace MultipleInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      var dragon = new Dragon
      {
        Weight = 100
      };
      dragon.Crawl();
      dragon.Fly();
    }
  }
}
