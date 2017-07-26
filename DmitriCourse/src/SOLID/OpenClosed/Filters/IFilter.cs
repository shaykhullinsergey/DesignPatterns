using System.Collections.Generic;

namespace OpenClosed
{
  public interface IFilter<T>
  {
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
  }
}
