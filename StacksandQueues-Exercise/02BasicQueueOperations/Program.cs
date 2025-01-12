namespace _02BasicQueueOperations
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
            Queue<int> queue = new Queue<int>(input);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            bool isFound = false;
            int minElement = int.MaxValue;

            foreach (int elements in queue)
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
