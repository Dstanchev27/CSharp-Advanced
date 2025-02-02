namespace _03CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallest = Smallest;
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(smallest(numbers));

        }

        public static int Smallest(int[] arg)
        {
            int small = int.MaxValue;
            foreach (int i in arg)
            {
                if (i < small)
                {
                    small = i;
                }
            }
            return small;
        }
    }
}
