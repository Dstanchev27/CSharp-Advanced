namespace _10RadioactiveMutantVampireBunnies
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }

                var parts = input.Split(":");
                string contest = parts[0];
                string password = parts[1];
                contests[contest] = password;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }

                var parts = input.Split("=>");
                string contest = parts[0];
                string password = parts[1];
                string username = parts[2];
                int points = int.Parse(parts[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, int>();
                    }

                    if (!users[username].ContainsKey(contest) || users[username][contest] < points)
                    {
                        users[username][contest] = points;
                    }
                }
            }

            var bestCandidate = users
                .OrderByDescending(u => u.Value.Values.Sum())
                .First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
