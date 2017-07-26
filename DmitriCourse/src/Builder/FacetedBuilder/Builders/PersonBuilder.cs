namespace FacetedBuilder
{
  public class PersonBuilder
  {
    protected Person person = new Person();

    public PersonJobBuilder Works => new PersonJobBuilder(person);
    public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

    public Person Build()
    {
      return person;
    }
  }
}
