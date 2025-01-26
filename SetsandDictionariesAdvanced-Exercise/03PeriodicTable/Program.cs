namespace _03PeriodicTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                for (int j = 0; j < input.Count; j++)
                {
                    set.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ", new SortedSet<string>(set)));
        }
    }
}
