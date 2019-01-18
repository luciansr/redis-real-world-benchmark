using Microsoft.EntityFrameworkCore;
using Repository.DatabaseModels;

namespace Repository.Context
{
    public class AppDbContext : DbContext
    {
        internal DbSet<HeavilyRequestedObject> HeavilyRequestedObjects { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO set relationships between tables

            // modelBuilder.Entity<HeavilyRequestedObject>().HasData(new HeavilyRequestedObject
            // {
            //     Id = 1,
            //     SomeProperty = "SomeProperty",
            //     AnotherImportantProperty = "AnotherImportantProperty"
            // });

            base.OnModelCreating(modelBuilder);
        }
    }
}