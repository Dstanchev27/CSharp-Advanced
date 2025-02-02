namespace _09PredicateParty_
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];
                string condition = commandParts[1];
                string parameter = commandParts[2];

                Predicate<string> filter = condition switch
                {
                    "StartsWith" => name => name.StartsWith(parameter),
                    "EndsWith" => name => name.EndsWith(parameter),
                    "Length" => name => name.Length == int.Parse(parameter),
                    _ => null
                };

                if (command == "Remove")
                {
                    guests.RemoveAll(filter);
                }
                else if (command == "Double")
                {
                    List<string> matches = guests.Where(g => filter(g)).ToList();
                    guests.AddRange(matches);
                }
            }

            Console.WriteLine(guests.Any()
                ? string.Join(", ", guests) + " are going to the party!"
                : "Nobody is going to the party!");
        }
    }
}
