namespace _08ListOfPredicates
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int, List<int>> listOfPredicates = ListOfPredicates;
            Action<List<int>> print = Print;

            numbers = listOfPredicates(numbers, n);
            print(numbers);
        }

        public static List<int> ListOfPredicates(List<int> list, int num)
        {
            var nums = new List<int>();
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                foreach (var number in list)
                {
                    if (i % number == 0)
                    {
                        count++;
                    }
                }

                if (count == list.Count)
                {
                    nums.Add(i);
                }

                count = 0;
            }

            return nums;
        }
        public static void Print(List<int> obj)
        {
            Console.WriteLine(string.Join(" ", obj));
        }
    }
}
