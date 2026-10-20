using System;
using System.Collections.Generic;

namespace Advanced01_G03
{
    #region Q20 - Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
    // Cache entries store a value and expiration time. Expired entries are treated as absent.
    public class Cache<TKey, TValue>
    {
        private class CacheEntry
        {
            public TValue Value { get; }
            public DateTime ExpirationTime { get; }

            public CacheEntry(TValue value, DateTime expirationTime)
            {
                Value = value;
                ExpirationTime = expirationTime;
            }
        }

        private readonly Dictionary<TKey, CacheEntry> _items = new Dictionary<TKey, CacheEntry>();

        public void Add(TKey key, TValue value, TimeSpan timeToLive)
        {
            _items[key] = new CacheEntry(value, DateTime.UtcNow.Add(timeToLive));
        }

        public TValue Get(TKey key)
        {
            if (!_items.TryGetValue(key, out CacheEntry entry))
                return default(TValue);

            if (DateTime.UtcNow >= entry.ExpirationTime)
            {
                _items.Remove(key);
                return default(TValue);
            }

            return entry.Value;
        }

        public bool Contains(TKey key)
        {
            if (!_items.TryGetValue(key, out CacheEntry entry))
                return false;

            if (DateTime.UtcNow >= entry.ExpirationTime)
            {
                _items.Remove(key);
                return false;
            }

            return true;
        }

        public bool Remove(TKey key)
        {
            return _items.Remove(key);
        }
    }
    #endregion
}
