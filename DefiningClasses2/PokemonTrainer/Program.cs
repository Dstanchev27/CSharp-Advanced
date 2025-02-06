namespace PokemonTrainer
{
    public class Program
    {
        public class StartUp
        {
            public static void Main()
            {
                var trainers = new List<Trainer>();

                string line;
                while ((line = Console.ReadLine()) != "Tournament")
                {
                    var tokens = line.Split();
                    string trainerName = tokens[0];
                    string pokemonName = tokens[1];
                    string pokemonElement = tokens[2];
                    int pokemonHealth = int.Parse(tokens[3]);

                    var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                    if (trainer == null)
                    {
                        trainer = new Trainer(trainerName);
                        trainers.Add(trainer);
                    }

                    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    trainer.Pokemons.Add(pokemon);
                }

                while ((line = Console.ReadLine()) != "End")
                {
                    string element = line;

                    foreach (var trainer in trainers)
                    {
                        var hasElement = trainer.Pokemons.Any(p => p.Element == element);

                        if (hasElement)
                        {
                            trainer.EarnBadge();
                        }
                        else
                        {
                            trainer.LoseHealth(element);
                        }
                    }
                }

                foreach (var trainer in trainers.OrderByDescending(t => t.Badges).ThenBy(t => trainers.IndexOf(t)))
                {
                    Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
                }
            }
        }
    }
}
