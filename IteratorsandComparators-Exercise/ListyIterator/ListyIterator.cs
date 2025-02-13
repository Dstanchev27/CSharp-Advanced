namespace ListyIterator
{
    using System.Collections;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private int index = 0;

        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator() => this.list.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (list.Count > 0 && index < list.Count)
            {
                Console.WriteLine(list[index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        public bool HasNext()
        {
            if (index + 1 < list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintAll()
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
