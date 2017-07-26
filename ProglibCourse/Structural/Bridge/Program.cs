using System;

namespace Bridge
{
  class Program
  {
    static void Main(string[] args)
    {
      var darkTheme = new DarkTheme();

      var about = new About(darkTheme);
      var careers = new Careers(darkTheme);

      Console.WriteLine(about.Content());
      Console.WriteLine(careers.Content());
    }
  }
  
  public interface IWebPage
  {
    string Content();
  }

  public class About : IWebPage
  {
    private ITheme theme;

    public About(ITheme theme)
    {
      this.theme = theme;
    }

    public string Content()
    {
      return $"About page, color is {theme.Color()}";
    }
  }

  public class Careers : IWebPage
  {
    private ITheme theme;

    public Careers(ITheme theme)
    {
      this.theme = theme;
    }

    public string Content()
    {
      return $"Careers page, color is {theme.Color()}";
    }
  }

  public interface ITheme
  {
    string Color();
  }

  public class DarkTheme : ITheme
  {
    public string Color()
    {
      return "Dark";
    }
  }

  public class LightTheme : ITheme
  {
    public string Color()
    {
      return "Light";
    }
  }
}
