namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public CustomStack()
        {
            elements = new List<T>();
        }

        public void Push(params T[] items)
        {
            elements.AddRange(items);
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T lastElement = elements[^1];
            elements.RemoveAt(elements.Count - 1);
            return lastElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
