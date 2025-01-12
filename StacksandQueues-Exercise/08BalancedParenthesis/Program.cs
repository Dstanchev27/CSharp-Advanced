namespace _08BalancedParenthesis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(IsBalanced(input) ? "YES" : "NO");
        }

        private static bool IsBalanced(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in sequence)
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        {
                            stack.Push(ch);
                            break;
                        }
                    case ')':
                        {
                            if (stack.Count == 0 || stack.Pop() != '(')
                            {
                                return false;
                            }
                            break;
                        }

                    case '}':
                        {
                            if (stack.Count == 0 || stack.Pop() != '{')
                            {
                                return false;
                            }
                            break;
                        }

                    case ']':
                        {
                            if (stack.Count == 0 || stack.Pop() != '[')
                            {
                                return false;
                            }
                            break;
                        }
                }
            }

            return stack.Count == 0;
        }
    }
}
