namespace _07PredicateForNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().Where(x => x.Length <= n).ToList();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
