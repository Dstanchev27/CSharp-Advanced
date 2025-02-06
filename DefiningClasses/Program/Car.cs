namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        // Задачи 6 и 7
        //    public string Model { get; }
        //    public Engine Engine { get; }
        //    public Cargo Cargo { get; }
        //    public List<Tire> Tires { get; }

        //    public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        //    {
        //        Model = model;
        //        Engine = engine;
        //        Cargo = cargo;
        //        Tires = tires;
        //    }
        //}

        //public class Engine
        //{
        //    public int Speed { get; }
        //    public int Power { get; }

        //    public Engine(int speed, int power)
        //    {
        //        Speed = speed;
        //        Power = power;
        //    }
        //}

        //public class Cargo
        //{
        //    public int Weight { get; }
        //    public string Type { get; }

        //    public Cargo(int weight, string type)
        //    {
        //        Weight = weight;
        //        Type = type;
        //    }
        //}

        //public class Tire
        //{
        //    public double Pressure { get; }
        //    public int Age { get; }

        //    public Tire(double pressure, int age)
        //    {
        //        Pressure = pressure;
        //        Age = age;
        //    }
        //}

        // Задача 8

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, int? weight = null, string color = null)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Model}:");
            stringBuilder.AppendLine($"  {Engine.ToString()}");
            stringBuilder.AppendLine($"  Weight: {(Weight.HasValue ? Weight.ToString() : "n/a")}");

            var color = !string.IsNullOrEmpty(Color) ? Color : "n/a";
            stringBuilder.Append($"  Color: {color}");

            return stringBuilder.ToString();
        }
    }
}
