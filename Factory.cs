namespace Advanced01_G03
{
    #region Q12 - How do you apply multiple constraints? Write an example.
    // T must inherit BookBase, implement IPrintable, and have a public parameterless constructor.
    public class Factory<T> where T : BookBase, IPrintable, new()
    {
        public T Create()
        {
            return new T();
        }
    }
    #endregion
}
