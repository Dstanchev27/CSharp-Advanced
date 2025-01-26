namespace _05CountSymbols
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbolCounts = new SortedDictionary<char, int>();

            foreach (char symbol in input)
            {
                if (!symbolCounts.ContainsKey(symbol))
                {
                    symbolCounts[symbol] = 0;
                }
                symbolCounts[symbol]++;
            }

            foreach (var pair in symbolCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
