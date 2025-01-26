namespace _01CountSameValuesinArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(double.Parse)
                                   .ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
