namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Задачи 1 и 2

            //Person person1 = new Person()
            //{
            //    Name = "Peter",
            //    Age = 20
            //};

            //Person person2 = new Person()
            //{
            //    Name = "George",
            //    Age = 18
            //};

            //Person person3 = new Person()
            //{
            //    Name = "Jose",
            //    Age = 43
            //};

            // Задача 3

            //int n = int.Parse(Console.ReadLine());
            //Family family = new Family();

            //for (int i = 0; i < n; i++)
            //{
            //    var names = Console.ReadLine().Split().ToList();
            //    Person person = new Person()
            //    {
            //        Name = names[0],
            //        Age = int.Parse(names[1])
            //    };

            //    family.AddMember(person);
            //}

            //string oldestMember = null;
            //oldestMember = family.GetOldestMember();

            //Console.WriteLine(oldestMember);

            // Задача 4

            //int n = int.Parse(Console.ReadLine());
            //List<Person> people = new List<Person>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    string name = input[0];
            //    int age = int.Parse(input[1]);

            //    people.Add(new Person(age, name));
            //}

            //foreach (var person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
            //{
            //    Console.WriteLine($"{person.Name} - {person.Age}");
            //}

            //Задача 5

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int difference = DateModifier.GetDateDifference(firstDate, secondDate);
            Console.WriteLine(difference);
        }
    }
}
