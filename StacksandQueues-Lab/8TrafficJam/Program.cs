namespace _8TrafficJam
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int totalCarsPassed = 0;

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n && queue.Count > 0; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        totalCarsPassed++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
