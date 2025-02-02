namespace _11TriFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isValidName = (name, sum) => name.Sum(c => c) >= sum;
            string result = names.FirstOrDefault(name => isValidName(name, targetSum));

            Console.WriteLine(result);
        }
    }
}