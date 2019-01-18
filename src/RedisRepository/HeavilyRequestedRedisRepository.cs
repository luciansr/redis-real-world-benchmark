using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Extensions.Caching.Distributed;
using Models;

namespace RedisRepository
{
    public class HeavilyRequestedRedisRepository
    {
        private IDistributedCache _distributedCache;
        private const string KEY_PREFIX = "HeavilyRequestedObjectKey";

        public HeavilyRequestedRedisRepository(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        private string getKey(int id)
        {
            return KEY_PREFIX + id;
        }
        public HeavilyRequestedObjectDTO GetHeavilyRequestedObjectById(int id)
        {
            var cachedObject = _distributedCache.Get(getKey(id));
            if (cachedObject == null) return null;

            return FromByteArray<HeavilyRequestedObjectDTO>(cachedObject);
        }

        public void InsertHeavilyRequestedObjectIntoCache(HeavilyRequestedObjectDTO realObject)
        {
            _distributedCache.Set(getKey(realObject.Id), ToByteArray(realObject), new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = new TimeSpan(0, 0, 15)
            });
        }

        public byte[] ToByteArray<T>(T obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }
    }
}
