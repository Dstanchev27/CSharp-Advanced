namespace _11KeyRevolver
{
    public class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int intelligenceValue = int.Parse(Console.ReadLine());

            int bulletsUsed = 0;
            int bulletsInBarrel = barrelSize;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();
                int lockValue = locks.Peek();
                bulletsUsed++;
                bulletsInBarrel--;

                if (bullet <= lockValue)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletsInBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletsInBarrel = barrelSize;
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = intelligenceValue - (bulletsUsed * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
