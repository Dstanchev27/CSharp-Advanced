namespace _04FastFood
{
    public class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            IEnumerable<int> input = Console.ReadLine().Split().Select(int.Parse);
            Queue<int> orders = new Queue<int>(input);

            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                int currentOrder = orders.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
