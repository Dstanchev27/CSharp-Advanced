namespace CustomComparator
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, CustomComparator);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static int CustomComparator(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0) return -1;
            if (x % 2 != 0 && y % 2 == 0) return 1;

            return x.CompareTo(y);
        }
    }
}
