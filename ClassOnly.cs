namespace Advanced01_G03
{
    #region Q8 - What is the 'class' constraint? Write an example.
    // T must be a reference type.
    public class ClassOnly<T> where T : class
    {
        public T Value { get; }

        public ClassOnly(T value)
        {
            Value = value;
        }
    }
    #endregion

}
