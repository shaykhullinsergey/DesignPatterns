namespace MultipleInheritance
{
  public class Dragon : IBird, ILizard
  {
    private Bird bird = new Bird();
    private Lizard lizard = new Lizard();

    private int weigth;
    public int Weight
    {
      get => weigth;
      set => weigth = bird.Weight = lizard.Weight = value;
    }

    public void Crawl()
    {
      lizard.Crawl();
    }

    public void Fly()
    {
      bird.Fly();
    }
  }
}
