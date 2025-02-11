namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lenght, T value)
        {
            T[] array = new T[lenght];
            
            for (int j = 0; j < lenght; j++)
            {
                array[j] = value;
            }

            return array;
        }
    }
}
