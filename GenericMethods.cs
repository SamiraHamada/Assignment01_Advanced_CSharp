using System;

namespace Advanced01_G03
{
    #region Q4 - What is a generic method? Write Swap<T> method.
    // A generic method can work with different data types.
    public static class GenericMethods
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temporary = first;
            first = second;
            second = temporary;
        }

        #endregion


        #region Q5 - Write a generic method FindMax<T> that finds maximum value.
        // IComparable<T> allows values to be compared.
        public static T FindMax<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
        #endregion

        #region Q13 - What does the 'default' keyword do in generics?
        // default(T) returns the default value for T, such as 0 for int or null for string.
        public static T GetDefault<T>()
        {
            return default(T);
        }
        #endregion
    }
}
