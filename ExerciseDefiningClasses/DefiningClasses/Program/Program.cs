namespace Program
{
    public class StartUp
    {
        public static void Main()
        {
            // Задача 6

            //int n = int.Parse(Console.ReadLine());
            //Dictionary<string, Car> cars = new Dictionary<string, Car>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] carInfo = Console.ReadLine().Split();
            //    string model = carInfo[0];
            //    double fuelAmount = double.Parse(carInfo[1]);
            //    double fuelConsumption = double.Parse(carInfo[2]);

            //    cars[model] = new Car(model, fuelAmount, fuelConsumption);
            //}

            //string command;
            //while ((command = Console.ReadLine()) != "End")
            //{
            //    string[] parts = command.Split();
            //    string carModel = parts[1];
            //    double distance = double.Parse(parts[2]);

            //    if (!cars[carModel].Drive(distance))
            //    {
            //        Console.WriteLine("Insufficient fuel for the drive");
            //    }
            //}

            //foreach (var car in cars.Values)
            //{
            //    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            //}

            //Задача 7

            //int n = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] carInfo = Console.ReadLine().Split();

            //    string model = carInfo[0];
            //    int engineSpeed = int.Parse(carInfo[1]);
            //    int enginePower = int.Parse(carInfo[2]);
            //    int cargoWeight = int.Parse(carInfo[3]);
            //    string cargoType = carInfo[4];

            //    Engine engine = new Engine(engineSpeed, enginePower);
            //    Cargo cargo = new Cargo(cargoWeight, cargoType);
            //    List<Tire> tires = new List<Tire>();

            //    for (int j = 5; j < carInfo.Length; j += 2)
            //    {
            //        double pressure = double.Parse(carInfo[j]);
            //        int age = int.Parse(carInfo[j + 1]);
            //        tires.Add(new Tire(pressure, age));
            //    }

            //    Car car = new Car(model, engine, cargo, tires);
            //    cars.Add(car);
            //}

            //string command = Console.ReadLine();

            //if (command == "fragile")
            //{
            //    var fragileCars = cars
            //        .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
            //        .Select(c => c.Model)
            //        .ToList();

            //    Console.WriteLine(string.Join(Environment.NewLine, fragileCars));
            //}
            //else if (command == "flammable")
            //{
            //    var flammableCars = cars
            //        .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
            //        .Select(c => c.Model)
            //        .ToList();

            //    Console.WriteLine(string.Join(Environment.NewLine, flammableCars));
            //}

            // Задача 8

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] input = Console.ReadLine().Trim().Split().Select(x => x.Trim()).ToArray();
                string model = input[0];
                int power = int.Parse(input[1]);

                int? displacement = null;
                string efficiency = null;

                if (input.Length == 4)
                {
                    int tempDisplacement;
                    if (int.TryParse(input[2], out tempDisplacement))
                    {
                        displacement = tempDisplacement;
                    }
                    efficiency = input[3];
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int tempDisplacement))
                    {
                        displacement = tempDisplacement;
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] input = Console.ReadLine().Trim().Split().Select(x => x.Trim()).ToArray();
                string model = input[0];
                string engineModel = input[1];

                Engine carEngine = engines.FirstOrDefault(e => e.Model == engineModel);
                if (carEngine == null)
                {
                    Console.WriteLine("Engine not found for car!");
                    continue;
                }

                int? weight = null;
                string color = null;

                if (input.Length == 4)
                {
                    int tempWeight;
                    if (int.TryParse(input[2], out tempWeight))
                    {
                        weight = tempWeight;
                    }
                    color = input[3];
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int tempWeight))
                    {
                        weight = tempWeight;
                    }
                    else
                    {
                        color = input[2];
                    }
                }

                cars.Add(new Car(model, carEngine, weight, color));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
