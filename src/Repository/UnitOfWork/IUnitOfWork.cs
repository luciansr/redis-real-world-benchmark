using Repository.Repositories;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        HeavilyRequestedRepository HeavilyRequestedObjects { get; set; }
    }
}