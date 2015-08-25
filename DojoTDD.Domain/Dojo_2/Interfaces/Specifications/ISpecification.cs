namespace DojoTDD.Domain.Dojo_2.Interfaces.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T obj);
    }
}
