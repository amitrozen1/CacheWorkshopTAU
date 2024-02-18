
using System.Collections.Generic;

namespace DataAccess
{
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _cache;
        private Dictionary<TKey, int> _frequencyCounter;
        private int _cacheMaxSize = 2;

        public Cache() 
        {
            _cache = new Dictionary<TKey, TValue>();
            _frequencyCounter = new Dictionary<TKey, int>();
        }
        public TValue Get(TKey key)
        {
            if (_cache.TryGetValue(key, out TValue value))
            {
                ++_frequencyCounter[key];
                return value;
            }

            return default;
        }

        public void Set(TKey key, TValue value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
                ++_frequencyCounter[key];
            }
            else
            {
                // Check if needs eviction first
                if (_cache.Count == _cacheMaxSize)
                {
                    EvictItemFromCache();
                }

                _cache.Add(key, value);
                _frequencyCounter.Add(key, 1);
            }
        }

        private void EvictItemFromCache()
        {
            var minCoutner = _frequencyCounter.Values.Min();
            var keyToEvict = _frequencyCounter.First(item => item.Value == minCoutner).Key;
            _cache.Remove(keyToEvict);
        }
    }
}
