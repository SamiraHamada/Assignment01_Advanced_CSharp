using System;

namespace Advanced01_G03
{
    public class Book : BookBase, IPrintable
    {
        public Book() : base("Untitled Book")
        {
        }

        public Book(string title) : base(title)
        {
        }

        public void Print()
        {
            Console.WriteLine($"Book: {Title}");
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
