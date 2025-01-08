namespace _6Supermarket
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Paid":
                        {
                            while (queue.Count > 0)
                            {
                                Console.WriteLine(queue.Dequeue());
                            }
                            break;
                        }
                    default:
                        {
                            queue.Enqueue(command);
                            break;
                        }
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
