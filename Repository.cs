using System.Collections.Generic;

namespace Advanced01_G03
{
    #region Q6 - What is a generic interface? Write IRepository<T>.
    // A generic interface defines a contract that works with different types.
    public interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }

    public class StringRepository : IRepository<string>
    {
        private readonly List<string> _items = new List<string>();

        public void Add(string item)
        {
            _items.Add(item);
        }

        public string GetById(int id)
        {
            return id >= 0 && id < _items.Count ? _items[id] : null;
        }
    }
    #endregion
}
