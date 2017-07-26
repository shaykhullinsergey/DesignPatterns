namespace OpenClosed
{
  public class AndSpecification<T> : ISpecification<T>
  {
    private ISpecification<T> first;
    private ISpecification<T> second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
      this.first = first;
      this.second = second;
    }

    public bool IsSatisfied(T type)
    {
      return first.IsSatisfied(type) && second.IsSatisfied(type);
    }
  }
}
