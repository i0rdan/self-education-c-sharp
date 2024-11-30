using System.Collections;
using System.Collections.ObjectModel;

namespace Dictionary_Library
{
    public class BiDictionary<TKey, TValue> : IBiDictionary<TKey, TValue>
    {
        private readonly List<KeyValuePair<TKey, TValue>> _items = new();

        public TValue this[TKey key]
        {
            get => _items.Find(item => item.Key!.Equals(key)).Value;
            set => Add(key, value);
        }

        public ICollection<TKey> Keys
        {
            get
            {
                var arr = new List<TKey>();

                foreach (var item in _items)
                {
                    arr.Add(item.Key);
                }

                return arr;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                var arr = new List<TValue>();

                foreach (var item in _items)
                {
                    arr.Add(item.Value);
                }

                return arr;
            }
        }

        public IReadOnlyDictionary<TValue, TKey> Inverse
        {
            get
            {
                var dict = new Dictionary<TValue, TKey>();

                foreach (var item in _items)
                {
                    if (item.Value is not null)
                    {
                        dict.TryAdd(item.Value, item.Key);
                    }
                }

                return new ReadOnlyDictionary<TValue, TKey>(dict);
            }
        }

        public int Count => _items.Count;

        public bool IsReadOnly => false;

        public void Add(TKey key, TValue value)
        {
            if (key is null)
            {
                throw new ArgumentException("Key must be not null!");
            }

            var item = new KeyValuePair<TKey, TValue>(key, value);

            Add(item);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            if (IsReadOnly)
            {
                throw new ArgumentException("Dictionary is read only!");
            }

            if (ContainsKey(item.Key))
            {
                throw new ArgumentException("Dictionary already contains a value with key!");
            }

            _items.Add(item);
        }

        public void Clear()
        {
            if (!IsReadOnly)
            {
                _items.Clear();
            }
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _items.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            if (key is null)
            {
                throw new ArgumentException("Key must not be null!");
            }

            return _items.Any(item => item.Key!.Equals(key));
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            _items.CopyTo(array, index);
        }

        public bool Remove(TKey key)
        {
            if (key is null)
            {
                throw new ArgumentException("Key must not be null!");
            }

            var item = _items.Find(item => item.Key!.Equals(key));

            return Remove(item);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (IsReadOnly || !ContainsKey(item.Key))
            {
                return false;
            }

            return _items.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (!ContainsKey(key))
            {
                value = default!;

                return false;
            }

            value = this[key];

            return true;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
