namespace Advanced01_G03
{
    #region Q18 - How do static members work in generic types?
    // Each closed generic type has its own static members.
    public class GenericCounter<T>
    {
        public static int Count;
    }
    #endregion

}
