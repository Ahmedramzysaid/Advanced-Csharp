using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01
{
   
    public class GenericCache<TKey, TValue>
    {

        public GenericCache() { }
        private Dictionary<TKey, (TValue Value, DateTime Expiration)> _cache = new Dictionary<TKey, (TValue, DateTime)>();



        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            _cache[key] = (value, DateTime.Now.Add(expiration));
        }
        public void Remove(TKey key)
        {
            _cache.Remove(key);
        }
        public bool Contains(TKey key)
        {
            return _cache.ContainsKey(key) && _cache[key].Expiration > DateTime.Now;
        }
        public TValue Get(TKey key)
        {
            if (Contains(key))
            {
                return _cache[key].Value;
            }
            throw new KeyNotFoundException("Key not found or expired.");
        }
        public bool CheckExpirationDate(TKey key)
        {
           
                if (_cache.ContainsKey(key))
                {
                    return _cache[key].Expiration > DateTime.Now;
                }
                throw new KeyNotFoundException("Key not found.");
        }




    }
}
