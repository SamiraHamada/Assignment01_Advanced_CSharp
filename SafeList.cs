using System.Collections.Generic;

namespace Advanced01_G03
{
    #region Q14 - Write a SafeList<T> that returns default when the index is invalid.
    // An invalid index returns default(T) instead of throwing an index exception.
    public class SafeList<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                return default(T);
            }

            return _items[index];
        }
    }
    #endregion
}
