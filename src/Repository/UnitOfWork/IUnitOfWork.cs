using Repository.Repositories;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        HeavilyRequestedObjectRepository HeavilyRequestedObjects { get; set; }
    }
}