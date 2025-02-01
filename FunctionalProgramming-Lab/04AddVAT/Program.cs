namespace _04AddVAT
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.2).Select(x => $"{x:f2}").ToArray();
            
            foreach (var pr in prices)
            {
                Console.WriteLine(pr);
            }
        }
    }
}
