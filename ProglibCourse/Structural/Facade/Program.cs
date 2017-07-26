using System;

namespace Facade
{
  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }

  public class PC
  {
    public string ElectrikShock() => "Ouch!";
    public string Sound() => "Beep";
    public string LoadingScreen() => "Loading...";
    public string Bam() => "Ready to use";
    public string CloseEverything() => "Bup bup bup bzz";
    public string Sooth() => "Zzzz";
    public string PullCurrent() => "Haaah!"; 
  }

  public class PCFacade
  {
    private PC pc;

    public PCFacade(PC pc)
    {
      this.pc = pc;
    }

    public void TurnOn()
    {
      pc.ElectrikShock();
      pc.Sound();
      pc.LoadingScreen();
      pc.Bam();
    }

    public void TurnOff()
    {
      pc.CloseEverything();
      pc.PullCurrent();
      pc.Sooth();
    }
  }
}
