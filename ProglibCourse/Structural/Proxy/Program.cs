using System;

namespace Proxy
{
  class Program
  {
    static void Main(string[] args)
    {
      var door = new SimpleDoor();
      var doorLock = new DoorLock(door);

      doorLock.Open("invalid");
      doorLock.Open("secret");
      doorLock.Close();
    }
  }

  public interface IDoor
  {
    void Open();
    void Close();
  }

  public class SimpleDoor : IDoor
  {
    public void Close()
    {
      Console.WriteLine("Opened");
    }

    public void Open()
    {
      Console.WriteLine("Closed");
    }
  }

  public class DoorLock
  {
    private IDoor door;

    public DoorLock(IDoor door)
    {
      this.door = door;
    }

    public void Open(string password)
    {
      if(Authenticate(password))
      {
          door.Open();
      }
      else
      {
          Console.WriteLine("Forbidden");
      }
    }

    public void Close()
    {
      door.Close();
    }

    private bool Authenticate(string password)
    {
      return password == "secret";
    }
  }
}
