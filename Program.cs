using System;

namespace Advanced01_G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - What is a generic class? Why use generics?
            // A generic class uses a type parameter such as T.
            // Generics make code reusable and type-safe for different data types.
            #endregion

            #region Q2 - Write a generic class Container<T> with Add and Get methods.
            Container<int> container = new Container<int>();
            container.Add(100);
            Console.WriteLine(container.Get());
            #endregion

            #region Q3 - What are multiple type parameters? Write Pair<TKey, TValue>.
            Pair<string, int> pair = new Pair<string, int>("Book", 5);
            Console.WriteLine($"{pair.First}, {pair.Second}");
            #endregion

            #region Q4 - What is a generic method? Write Swap<T> method.
            int first = 10;
            int second = 20;
            GenericMethods.Swap(ref first, ref second);
            Console.WriteLine($"{first}, {second}");
            #endregion

            #region Q5 - Write a generic method FindMax<T> that finds maximum value.
            Console.WriteLine(GenericMethods.FindMax(12, 30));
            #endregion

            #region Q6 - What is a generic interface? Write IRepository<T>.
            IRepository<string> repository = new StringRepository();
            repository.Add("Clean Code");
            Console.WriteLine(repository.GetById(0));
            #endregion

            #region Q7 - What is the 'struct' constraint? Write an example.
            StructOnly<int> structValue = new StructOnly<int>(10);
            Console.WriteLine(structValue.Value);
            #endregion

            #region Q8 - What is the 'class' constraint? Write an example.
            ClassOnly<Book> classValue = new ClassOnly<Book>(new Book("Clean Code"));
            Console.WriteLine(classValue.Value.Title);
            #endregion

            #region Q9 - What is the 'new()' constraint? Write an example.
            CreateObject<Book> creator = new CreateObject<Book>();
            Console.WriteLine(creator.Create().Title);
            #endregion

            #region Q10 - What is the interface constraint? Write an example.
            PrintableBox<Book> printableBox = new PrintableBox<Book>(new Book("Clean Code"));
            printableBox.Print();
            #endregion

            #region Q11 - What is the base class constraint? Write an example.
            Repository<Book> bookRepository = new Repository<Book>();
            bookRepository.Save(new Book("Atomic Habits"));
            Console.WriteLine(bookRepository.Get().Title);
            #endregion

            #region Q12 - How do you apply multiple constraints? Write an example.
            Factory<Book> factory = new Factory<Book>();
            Console.WriteLine(factory.Create().Title);
            #endregion

            #region Q13 - What does the 'default' keyword do in generics?
            Console.WriteLine(GenericMethods.GetDefault<int>());
            Console.WriteLine(GenericMethods.GetDefault<string>() ?? "null");
            #endregion

            #region Q14 - Write a SafeList<T> that returns default when the index is invalid.
            SafeList<string> safeList = new SafeList<string>();
            safeList.Add("First");
            Console.WriteLine(safeList.Get(0));
            Console.WriteLine(safeList.Get(5) ?? "Invalid index");
            #endregion

            #region Q15 - What is covariance? Explain the 'out' keyword.
            IProducer<Book> bookProducer = new Producer<Book>(new Book("Clean Code"));
            IProducer<object> objectProducer = bookProducer;
            Console.WriteLine(objectProducer.Produce());
            #endregion

            #region Q16 - What is contravariance? Explain the 'in' keyword.
            IConsumer<object> objectConsumer = new Consumer<object>();
            IConsumer<Book> bookConsumer = objectConsumer;
            bookConsumer.Consume(new Book("Clean Code"));
            #endregion

            #region Q17 - What is the difference between covariance and contravariance?
            // Covariance (out) is used when a generic type produces/returns T.
            // Contravariance (in) is used when a generic type consumes/accepts T.
            #endregion

            #region Q18 - How do static members work in generic types?
            GenericCounter<int>.Count++;
            GenericCounter<int>.Count++;
            GenericCounter<string>.Count++;
            Console.WriteLine(GenericCounter<int>.Count);
            Console.WriteLine(GenericCounter<string>.Count);
            #endregion

            #region Q19 - How can you inherit from a generic class?
            SpecialContainer<string> specialContainer = new SpecialContainer<string>();
            specialContainer.Add("Hello");
            Console.WriteLine(specialContainer.Get());
            #endregion

            #region Q20 - Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
            Cache<string, string> cache = new Cache<string, string>();
            cache.Add("user", "Sam", TimeSpan.FromMinutes(5));
            Console.WriteLine(cache.Get("user"));
            Console.WriteLine(cache.Contains("user"));
            cache.Remove("user");
            Console.WriteLine(cache.Contains("user"));
            #endregion
        }
    }
}
