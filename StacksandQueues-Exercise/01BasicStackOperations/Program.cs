namespace _01BasicStackOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums[0];
            int s = nums[1];
            int x = nums[2];
            IEnumerable<int> input = Console.ReadLine().Split().Select(int.Parse);
            Stack<int> stack = new Stack<int>(input);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            bool isFound = false;
            int minElement = int.MaxValue;

            foreach (int elements in stack)
            {
                if (elements == x)
                {
                    isFound = true;
                    break;
                }

                if (elements < minElement)
                {
                    minElement = elements;
                }
            }

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(minElement);
            }
        }
    }
}
