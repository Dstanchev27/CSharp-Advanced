namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //var tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3)
            //};

            //var engine = new Engine(560, 6300);

            ////Car car1 = new Car();
            ////Car car2 = new Car(make, model, year);
            //Car car3 = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);

            //Console.WriteLine($"{car1.Make} {car1.Model} {car1.Year} - Fuel: {car1.FuelQuantity}, Consumption: {car1.FuelConsumption}");
            //Console.WriteLine($"{car2.Make} {car2.Model} {car2.Year} - Fuel: {car2.FuelQuantity}, Consumption: {car2.FuelConsumption}");
            //Console.WriteLine($"{car3.Make} {car3.Model} {car3.Year} - Fuel: {car3.FuelQuantity}, Consumption: {car3.FuelConsumption}");

            //Car vw = new Car()
            //{
            //    Make = "VW",
            //    Model = "Golf",
            //    Year = 2025,
            //    FuelQuantity = 200,
            //    FuelConsumption = 10
            //};

            //vw.Drive(1);

            //Console.WriteLine(vw.WhoAmI());
            //Console.WriteLine($"Make: {bmw.Make}\nModel: {bmw.Model}\nYear: {bmw.Year}");

            List<Tire[]> tiresCollection = new List<Tire[]>();
            string input;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireData = input.Split();
                Tire[] tires = new Tire[4];

                for (int i = 0; i < 4; i++)
                {
                    int year = int.Parse(tireData[i * 2]);
                    double pressure = double.Parse(tireData[i * 2 + 1]);
                    tires[i] = new Tire(year, pressure);
                }

                tiresCollection.Add(tires);
            }

            List<Engine> enginesCollection = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineData = input.Split();
                int horsePower = int.Parse(engineData[0]);
                double cubicCapacity = double.Parse(engineData[1]);
                enginesCollection.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carData = input.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Engine carEngine = enginesCollection[engineIndex];
                Tire[] carTires = tiresCollection[tiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, carEngine, carTires);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                double totalTirePressure = car.Tires.Sum(t => t.Pressure);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && totalTirePressure > 9 && totalTirePressure < 10)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}{Environment.NewLine}Model: {car.Model}{Environment.NewLine}Year: {car.Year}{Environment.NewLine}HorsePowers: {car.Engine.HorsePower}{Environment.NewLine}FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
