namespace _3SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();
            Stack<string> stack = new Stack<string>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                stack.Push(tokens[i]);
            }

            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    result += number;
                }
                else if (operation == "-")
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
