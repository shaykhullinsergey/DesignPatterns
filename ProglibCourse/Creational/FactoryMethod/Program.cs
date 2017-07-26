using System;

namespace FactoryMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      var devManager = new DevelopmentManager();
      devManager.TakeInterviewer();

      var marketingManager = new MarketingManager();
      marketingManager.TakeInterviewer();
    }
  }

  public interface IInterviewer
  {
    void AskQuestion();
  }

  public class Developer : IInterviewer
  {
    public void AskQuestion()
    {
      Console.WriteLine("Developer");
    }
  }

  public class CommunityExecutive : IInterviewer
  {
    public void AskQuestion()
    {
      Console.WriteLine("CommunityExecutive");
    }
  }

  public abstract class HiringManager 
  {
    protected abstract IInterviewer MakeInterviewer();

    public void TakeInterviewer()
    {
      var interviewer = MakeInterviewer();
      interviewer.AskQuestion();
    }
  }

  public class DevelopmentManager : HiringManager
  {
    protected override IInterviewer MakeInterviewer()
    {
      return new Developer();
    }
  }

  public class MarketingManager : HiringManager
  {
    protected override IInterviewer MakeInterviewer()
    {
      return new CommunityExecutive();
    }
  }
}
