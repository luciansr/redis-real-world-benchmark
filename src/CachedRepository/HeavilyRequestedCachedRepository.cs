using System;
using Models;
using RedisRepository;
using Repository.Repositories;

namespace CachedRepository
{
    public class HeavilyRequestedCachedRepository
    {
        private HeavilyRequestedRedisRepository _heavilyRequestedRedisRepository;
        private HeavilyRequestedRepository _heavilyRequestedRepository;

        public HeavilyRequestedCachedRepository(
            HeavilyRequestedRedisRepository heavilyRequestedRedisRepository,
            HeavilyRequestedRepository heavilyRequestedRepository)
        {
            _heavilyRequestedRedisRepository = heavilyRequestedRedisRepository;
            _heavilyRequestedRepository = heavilyRequestedRepository;
        }
        public HeavilyRequestedObjectDTO GetHeavilyRequestedObjectById(int id)
        {
            HeavilyRequestedObjectDTO cachedObject = _heavilyRequestedRedisRepository.GetHeavilyRequestedObjectById(id);
            if(cachedObject != null) return cachedObject; 

            HeavilyRequestedObjectDTO realObject =  _heavilyRequestedRepository.GetHeavilyRequestedObjectById(id);
            _heavilyRequestedRedisRepository.InsertHeavilyRequestedObjectIntoCache(realObject);
            
            return realObject;
        }
    }
}
