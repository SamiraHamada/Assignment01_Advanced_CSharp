namespace Advanced01_G03
{
    #region Q11 - What is the base class constraint? Write an example.
    // T must inherit from BookBase.
    public class Repository<T> where T : BookBase
    {
        private T _item;

        public void Save(T item)
        {
            _item = item;
        }

        public T Get()
        {
            return _item;
        }
    }
    #endregion
}
