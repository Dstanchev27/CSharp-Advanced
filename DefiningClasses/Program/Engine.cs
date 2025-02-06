namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Engine
    {
        public string Model { get; }
        public int Power { get; }
        public int? Displacement { get; }
        public string Efficiency { get; }

        public Engine(string model, int power, int? displacement = null, string efficiency = null)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Model}:");
            stringBuilder.AppendLine($"    Power: {Power}");
            stringBuilder.AppendLine($"    Displacement: {(Displacement.HasValue ? Displacement.ToString() : "n/a")}");
            stringBuilder.Append($"    Efficiency: {(Efficiency ?? "n/a")}");

            return stringBuilder.ToString();
        }
    }
}
