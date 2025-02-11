namespace GenericCountMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Box<T> where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public int CompareTo(T other)
        {
            return this.value.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {value}";
        }

        public static int CountGreaterThan(List<Box<T>> list, T element)
        {
            int count = 0;
            foreach (var box in list)
            {
                if (box.value.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
