namespace _01SortEvenNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
