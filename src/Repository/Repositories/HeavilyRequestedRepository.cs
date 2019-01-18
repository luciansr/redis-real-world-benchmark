using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.DatabaseModels;

namespace Repository.Repositories
{
    public class HeavilyRequestedRepository
    {
        private DbSet<HeavilyRequestedObject> _dbSet;

        public HeavilyRequestedRepository(AppDbContext context)
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