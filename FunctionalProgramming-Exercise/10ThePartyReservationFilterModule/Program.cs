namespace _10ThePartyReservationFilterModule
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            HashSet<string> filters = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] commandParts = input.Split(';');
                string action = commandParts[0];
                string condition = commandParts[1];
                string parameter = commandParts[2];
                string filterKey = condition + ";" + parameter;

                if (action == "Add filter")
                {
                    filters.Add(filterKey);
                }
                else if (action == "Remove filter")
                {
                    filters.Remove(filterKey);
                }
            }

            foreach (var filter in filters)
            {
                string[] filterParts = filter.Split(';');
                string condition = filterParts[0];
                string parameter = filterParts[1];

                Predicate<string> predicate = GetPredicate(condition, parameter);
                guests.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", guests));
        }

        private static Predicate<string> GetPredicate(string condition, string parameter)
        {
            return condition switch
            {
                "Starts with" => name => name.StartsWith(parameter),
                "Ends with" => name => name.EndsWith(parameter),
                "Length" => name => name.Length == int.Parse(parameter),
                "Contains" => name => name.Contains(parameter),
                _ => null
            };
        }
    }
}

