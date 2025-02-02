namespace _01ActionPrint
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            Action<string[]> printAction = PrintNames;
            printAction(names);
        }

        static void PrintNames(string[] namesArray)
        {
            foreach (var name in namesArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}