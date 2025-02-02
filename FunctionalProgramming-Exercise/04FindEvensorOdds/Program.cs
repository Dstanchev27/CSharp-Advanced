namespace _04FindEvensorOdds
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Predicate<int> isEven = num => num % 2 == 0;
            Predicate<int> isOdd = num => num % 2 != 0;

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (command == "even" && isEven(i))
                {
                    Console.Write(i + " ");
                }
                else if (command == "odd" && isOdd(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
