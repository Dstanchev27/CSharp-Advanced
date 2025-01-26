namespace _07ParkingLot
{
    using System.Globalization;

    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "END")
            {
                string command = input[0];
                string numberPlate = input[1];

                switch (command)
                {
                    case "IN":
                        {
                            set.Add(numberPlate);
                            break;
                        }
                    case "OUT":
                        {
                            set.Remove(numberPlate);
                            break;
                        }
                    default:
                        break;
                }

               input = Console.ReadLine().Split(", ");
            }

            if (set.Count > 0)
            {
                foreach (string s in set)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
