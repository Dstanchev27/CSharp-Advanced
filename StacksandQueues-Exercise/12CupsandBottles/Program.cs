namespace _12CupsandBottles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cup = cups.Peek();
                while (cup > 0 && bottles.Count > 0)
                {
                    int bottle = bottles.Pop();
                    if (bottle >= cup)
                    {
                        wastedWater += bottle - cup;
                        cup = 0;
                    }
                    else
                    {
                        cup -= bottle;
                    }
                }
                if (cup == 0)
                {
                    cups.Dequeue();
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
