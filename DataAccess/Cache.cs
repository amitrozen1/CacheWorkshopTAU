
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
            if (_cache.TryGetValue(key, out TValue value))
            {
                return value;
            }

            return default;
        }

        public void Set(TKey key, TValue value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
            else 
            { 
                _cache.Add(key, value);
            }
        }
    }
}
