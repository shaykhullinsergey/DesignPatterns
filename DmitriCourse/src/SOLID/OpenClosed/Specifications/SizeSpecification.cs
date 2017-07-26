namespace OpenClosed
{
  public class SizeSpecification : ISpecification<Product>
  {
    private Size size;

    public SizeSpecification(Size size)
    {
      this.size = size;
    }

    public bool IsSatisfied(Product product)
    {
      return product.Size == size;
    }
  }
}
