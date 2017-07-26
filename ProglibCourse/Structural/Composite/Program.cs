using System.Collections.Generic;

namespace Composite
{
  class Program
  {
    static void Main(string[] args)
    {
      var john = new Developer("John", 100);
      var jane = new Designer("Jane", 200);

      var organisation = new Organisation();
      organisation.AddEmployee(john);
      organisation.AddEmployee(jane);

      var total = organisation.TotalSalary();
    }
  }

  public interface IEmployee
  {
    string Name { get; }
    float Salary { get; set; }
  }

  public class Developer : IEmployee
  {
    public string Name { get; private set; }
    public float Salary { get; set; }

    public Developer(string name, float salary)
    {
      this.Name = name;
      this.Salary = salary;
    }
  }

  public class Designer : IEmployee
  {
    public string Name { get; private set; }
    public float Salary { get; set; }

    public Designer(string name, float salary)
    {
      this.Name = name;
      this.Salary = salary;
    }
  }

  public class Organisation
  {
    private List<IEmployee> employees = new List<IEmployee>();

    public void AddEmployee(IEmployee employee)
    {
      employees.Add(employee);
    }

    public float TotalSalary()
    {
      float salary = 0f;

      foreach (var employee in employees)
      {
        salary += employee.Salary;
      }
      
      return salary;
    }
  }
}
