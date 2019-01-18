using System;
using System.Collections.Generic;
using CachedRepository;
using Models;

namespace Services
{
    public class BenchmarkService
    {
        private HeavilyRequestedCachedRepository _heavilyRequestedCachedRepository;

        public BenchmarkService(HeavilyRequestedCachedRepository heavilyRequestedCachedRepository)
        {
            _heavilyRequestedCachedRepository = heavilyRequestedCachedRepository;
        }

        public HeavilyRequestedObjectDTO GetHeavilyRequestedObjectById(int id)
        {
            return _heavilyRequestedCachedRepository.GetHeavilyRequestedObjectById(id);
        }
    }
}
