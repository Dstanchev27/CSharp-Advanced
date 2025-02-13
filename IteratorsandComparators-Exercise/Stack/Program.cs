namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END") break;

                string[] parts = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                try
                {
                    if (command == "Push")
                    {
                        int[] numbers = parts.Skip(1).Select(int.Parse).ToArray();
                        stack.Push(numbers);
                    }
                    else if (command == "Pop")
                    {
                        stack.Pop();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
