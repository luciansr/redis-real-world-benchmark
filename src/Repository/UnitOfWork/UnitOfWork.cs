using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Repositories;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public static bool Migrated = false;
        private AppDbContext _context;

        public UnitOfWork(
            AppDbContext context,
            HeavilyRequestedObjectRepository userRepository)
        {
            _context = context;
            HeavilyRequestedObjects = userRepository;

            //use only locally
            if (!Migrated)
            {
                _context.Database.Migrate();
                Migrated = true;
            }
        }
        public HeavilyRequestedObjectRepository HeavilyRequestedObjects { get; set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}