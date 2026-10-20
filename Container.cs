namespace Advanced01_G03
{
    #region Q2 - Write a generic class Container<T> with Add and Get methods.
    // Stores one value of type T and lets us add or retrieve it.
    public class Container<T>
    {
        private T _value = default(T);

        public void Add(T value)
        {
            _value = value;
        }

        public T Get()
        {
            return _value;
        }
    }
    #endregion

}
