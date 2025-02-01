namespace _03CountUppercaseWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filter = IsUppercaseFilter;
            var text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x => filter(x));

            foreach (var x in text)
            {
                Console.WriteLine(x);
            }
        }

        static bool IsUppercaseFilter(string text)
        {
            return char.IsUpper(text[0]);
        }
    }
}
