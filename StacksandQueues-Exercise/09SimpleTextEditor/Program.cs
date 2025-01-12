namespace _09SimpleTextEditor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> states = new Stack<string>(); 
            string text = "";

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "1":
                        states.Push(text);
                        text += commandParts[1];
                        break;

                    case "2":
                        states.Push(text);
                        int count = int.Parse(commandParts[1]);
                        text = text.Substring(0, text.Length - count);
                        break;

                    case "3": 
                        int index = int.Parse(commandParts[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;

                    case "4":
                        if (states.Count > 0)
                        {
                            text = states.Pop();
                        }
                        break;
                }
            }
        }
    }
}
