namespace ComparingObjects
{
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string town = parts[2];

                people.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= people.Count)
            {
                Console.WriteLine("No matches");
                return;
            }

            Person referencePerson = people[index];
            int matches = 0, nonMatches = 0;

            foreach (var person in people)
            {
                if (referencePerson.CompareTo(person) == 0)
                    matches++;
                else
                    nonMatches++;
            }

            if (matches > 1)
            {
                Console.WriteLine($"{matches} {nonMatches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
