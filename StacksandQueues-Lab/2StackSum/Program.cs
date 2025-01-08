namespace _2StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split();

                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "add":
                        {
                            stack.Push(int.Parse(command[1]));
                            stack.Push(int.Parse(command[2]));
                            break;
                        }
                    case "remove":
                        {
                            int count = int.Parse(command[1]);

                            if (stack.Count >= count)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    stack.Pop();
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }
            }

            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
