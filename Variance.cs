using System;

namespace Advanced01_G03
{
    #region Q15 - What is covariance? Explain the 'out' keyword.
    // out allows a producer of a more specific type to be used as a producer of a more general type.
    public interface IProducer<out T>
    {
        T Produce();
    }

    public class Producer<T> : IProducer<T>
    {
        private readonly T _value;

        public Producer(T value)
        {
            _value = value;
        }

        public T Produce()
        {
            return _value;
        }
    }
    #endregion

    #region Q16 - What is contravariance? Explain the 'in' keyword.
    // in allows a consumer of a general type to be used as a consumer of a more specific type.
    public interface IConsumer<in T>
    {
        void Consume(T item);
    }

    public class Consumer<T> : IConsumer<T>
    {
        public void Consume(T item)
        {
            Console.WriteLine(item);
        }
    }
    #endregion

}
