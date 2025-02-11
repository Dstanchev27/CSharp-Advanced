namespace GenericSwapMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public static void Swap(List<Box<T>> list, int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {value}";
        }
    }
}
