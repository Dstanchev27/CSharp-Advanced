namespace _10Crossroads
{
    public class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int totalCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    int greenLight = greenLightDuration;

                    while (queue.Count > 0 && greenLight > 0)
                    {
                        string car = queue.Dequeue();
                        if (greenLight >= car.Length)
                        {
                            greenLight -= car.Length;
                            totalCarsPassed++;
                        }
                        else
                        {
                            int remainingTime = car.Length - greenLight;
                            if (remainingTime <= freeWindowDuration)
                            {
                                totalCarsPassed++;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[greenLight + freeWindowDuration]}.");
                                return;
                            }
                            greenLight = 0;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}
