namespace _02AverageStudentGrades
{
    using System.Globalization;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1], CultureInfo.InvariantCulture);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                string grades = string.Join(" ", student.Value.Select(g => g.ToString("F2")));
                decimal avg = student.Value.Average();
                Console.WriteLine($"{student.Key} -> {grades} (avg: {avg:F2})");
            }
        }
    }
}
