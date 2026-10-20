namespace Advanced01_G03
{
    #region Q3 - What are multiple type parameters? Write Pair<TKey, TValue>.
    // Multiple type parameters allow a class to store values of different types.
    public class Pair<TKey, TValue>
    {
        public TKey First { get; }
        public TValue Second { get; }

        public Pair(TKey first, TValue second)
        {
            First = first;
            Second = second;
        }
    }
    #endregion

}
