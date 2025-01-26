namespace _02SetsofElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = lenght[0];
            int m = lenght[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0;i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            List<int> list = new List<int>();

            foreach (int i in set1)
            {
                foreach (int j in set2)
                {
                    if (j == i)
                    {
                        list.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
