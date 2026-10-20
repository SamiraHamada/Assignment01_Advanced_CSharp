namespace Advanced01_G03
{
    #region Q7 - What is the 'struct' constraint? Write an example.
    // T must be a non-nullable value type.
    public class StructOnly<T> where T : struct
    {
        public T Value { get; }

        public StructOnly(T value)
        {
            Value = value;
        }
    }
    #endregion
}
