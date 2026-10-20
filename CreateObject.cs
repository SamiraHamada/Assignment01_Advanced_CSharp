namespace Advanced01_G03
{
    #region Q9 - What is the 'new()' constraint? Write an example.
    // T must have a public parameterless constructor.
    public class CreateObject<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    #endregion

}
