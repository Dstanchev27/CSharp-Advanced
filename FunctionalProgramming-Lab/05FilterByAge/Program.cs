namespace _05FilterByAge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people[input[0]] = int.Parse(input[1]);
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Dictionary<string, int> filteredPeople = FilterPeople(people, condition, ageThreshold);
            PrintPeople(filteredPeople, format);
        }

        static Dictionary<string, int> FilterPeople(Dictionary<string, int> people, string condition, int ageThreshold)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var person in people)
            {
                if ((condition == "older" && person.Value >= ageThreshold) ||
                    (condition == "younger" && person.Value < ageThreshold))
                {
                    result[person.Key] = person.Value;
                }
            }
            return result;
        }

        static void PrintPeople(Dictionary<string, int> people, string format)
        {
            foreach (var person in people)
            {
                if (format == "name")
                {
                    Console.WriteLine(person.Key);
                }
                else if (format == "age")
                {
                    Console.WriteLine(person.Value);
                }
                else if (format == "name age")
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }
    }
}