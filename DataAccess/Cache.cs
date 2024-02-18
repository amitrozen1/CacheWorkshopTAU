using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _cache;

        public Cache() 
        {
            _cache = new Dictionary<TKey, TValue>();
        }
        public TValue Get(TKey key)
        {
            // Implement get item by key from the cache
            return default;
        }

        public void Set(TKey key, TValue value)
        {
            // Implement setting item by key to the cache
        }
    }
}
