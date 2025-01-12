namespace _05FashionBoutique
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> input = Console.ReadLine().Split().Select(int.Parse);
            Stack<int> stack = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                int currentClothing = stack.Pop();

                if (sum + currentClothing <= capacity)
                {
                    sum += currentClothing;
                }
                else
                {
                    racks++;
                    sum = currentClothing;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
