namespace _06ReverseAndExclude
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Func<int[], int[]> exclude = nums => nums.Where(x => x % n != 0).ToArray();
            Action<int[]> reverse = Reverse;
            numbers = exclude(numbers);
            reverse(numbers);
        }

        public static void Reverse(int[] arg)
        {
            List<int> result = new List<int>();

            foreach (var item in arg)
            {
                result.Add(item);
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
