namespace Advanced01_G03
{
    #region Q10 - What is the interface constraint? Write an example.
    // T must implement IPrintable.
    public interface IPrintable
    {
        void Print();
    }

    public class PrintableBox<T> where T : IPrintable
    {
        private readonly T _item;

        public PrintableBox(T item)
        {
            _item = item;
        }

        public void Print()
        {
            _item.Print();
        }
    }
    #endregion

}
