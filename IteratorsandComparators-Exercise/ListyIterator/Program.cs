using System.Data;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            if (input[0] == "END")
            {
                return;
            }
            else if (input[0].ToLower() != "create")
            {
                Console.WriteLine("Invalid Operation!");
            }

            var creation = input.Skip(1).Select(x => x.Trim()).ToList();
            var list = new ListyIterator<string>(creation);

            string command = Console.ReadLine().Trim();

            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        {
                            var result = list.Move();

                            Console.WriteLine(result);
                            break;
                        }
                    case "Print":
                        {
                            list.Print();
                            break;
                        }
                    case "HasNext":
                        {
                            var result = list.HasNext();

                            Console.WriteLine(result);
                            break;
                        }
                    case "PrintAll":
                    {
                        list.PrintAll();
                        break;
                    }
                }

                command = Console.ReadLine().Trim();
            }
        }
    }
}
