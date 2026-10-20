namespace Advanced01_G03
{
    public class BookBase
    {
        public string Title { get; set; }

        public BookBase()
        {
            Title = "Untitled";
        }

        public BookBase(string title)
        {
            Title = title;
        }
    }
}
