using System.Collections.Generic;

namespace DependencyInversion
{
  public interface IRelationshipBrowser
  {
    IEnumerable<Person> FindAllChildrenOf(string name);
  }
}
