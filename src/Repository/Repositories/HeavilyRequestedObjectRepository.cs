using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.DatabaseModels;

namespace Repository.Repositories
{
    public class HeavilyRequestedObjectRepository
    {
        private DbSet<HeavilyRequestedObject> _dbSet;

        public HeavilyRequestedObjectRepository(AppDbContext context)
        {
            _dbSet = context.HeavilyRequestedObjects;
        }
        public HeavilyRequestedObjectDTO GetHeavilyRequestedObjectById(int id)
        {
            return _dbSet.Where(u => u.Id == id).Select(u => new HeavilyRequestedObjectDTO
            {
                Id = u.Id,
                SomeProperty = u.SomeProperty,
                AnotherImportantProperty = u.AnotherImportantProperty
            }).FirstOrDefault();
        }

    }
}