namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }

        public void EarnBadge()
        {
            Badges++;
        }

        public void LoseHealth(string element)
        {
            foreach (var pokemon in Pokemons.ToList())
            {
                if (pokemon.Element != element)
                {
                    pokemon.Health -= 10;
                    if (pokemon.Health <= 0)
                    {
                        Pokemons.Remove(pokemon);
                    }
                }
            }
        }
    }
}
