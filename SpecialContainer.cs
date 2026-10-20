namespace Advanced01_G03
{
    #region Q19 - How can you inherit from a generic class?
    // A derived class can inherit from a generic base class.
    public class SpecialContainer<T> : Container<T>
    {
    }
    #endregion
}
