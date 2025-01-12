namespace _07TruckTour
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<(int Fuel, int Distance)> stations = new Queue<(int Fuel, int Distance)>();

            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = data[0];
                int distance = data[1];

                var station = (fuel, distance);
                stations.Enqueue(station);
            }

            for (int i = 0; i < n; i++)
            {
                int capacity = 0;
                bool success = true;

                foreach (var station in stations)
                {
                    capacity += station.Fuel;

                    if (capacity < station.Distance)
                    {
                        success = false;
                    }

                    capacity -= station.Distance;
                }

                if (success)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    stations.Enqueue(stations.Dequeue());
                }
            }
        }
    }
}
