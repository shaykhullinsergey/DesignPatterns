﻿namespace FacetedBuilder
{
  public class PersonJobBuilder : PersonBuilder
  {
    public PersonJobBuilder(Person person)
    {
      this.person = person;
    }

    public PersonJobBuilder At(string companyName)
    {
      person.CompanyName = companyName;
      return this;
    }

    public PersonJobBuilder AsA(string position)
    {
      person.Position = position;
      return this;
    }

    public PersonJobBuilder Earning(int amount)
    {
      person.AnnualIncome = amount;
      return this;
    }
  }
}
