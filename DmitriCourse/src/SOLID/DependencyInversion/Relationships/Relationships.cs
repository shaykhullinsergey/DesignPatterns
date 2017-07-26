using System.Linq;
using System.Collections.Generic;

namespace DependencyInversion
{
  //low-level
  public class Relationships : IRelationshipBrowser
  {
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
      relations.Add((parent, Relationship.Parent, child));
      relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
      return relations.Where(relation => 
          relation.Item1.Name == name && 
          relation.Item2 == Relationship.Parent)
        .Select(r => r.Item3);
    }
  } 
}
