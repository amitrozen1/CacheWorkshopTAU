
namespace DataAccess
{
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, (TValue, getVal)> _cache;

        public Cache() 
        {
            _cache = new Dictionary<TKey, TValue>();
        }
        public TValue Get(TKey key)
        {
            if (_cache.TryGetValue(key, out TValue value))
            {
                _cache[key] += 1;
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

        public void delete(){

            int minUse = 0;
            TKey LRUKey = null;

            for (key in _cache)
            {
                if (LRUKey == null){
                    LRUKey = key;
                    minUse = _cache[key(1)];
                }

                else{
                    if (_cache[key(1)] < minUse){
                        LRUKey = key;
                        minUse = _cache[key(1)];
                    }
                }
            }
        }
    }
}
