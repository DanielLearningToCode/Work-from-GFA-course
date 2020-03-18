using System;
using System.Collections.Generic;

namespace GreenFoxAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", PokemonType.Leaf, PokemonType.Water);

            // Which pokemon should Ash use?
            Pokemon myPokemon = null;
            foreach (var pokemon in pokemonOfAsh)
            {
                if (pokemon.IsEffectiveAgainst(wildPokemon))
                {
                    myPokemon = pokemon;
                    break;
                }
            }
            if (myPokemon != null)
            {
                Console.Write($"I choose you, {myPokemon.Name}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", PokemonType.Leaf, PokemonType.Water),
                new Pokemon("Pikatchu", PokemonType.Electric, PokemonType.Water),
                new Pokemon("Charizard", PokemonType.Fire, PokemonType.Leaf),
                new Pokemon("Balbasaur", PokemonType.Water, PokemonType.Fire),
                new Pokemon("Kingler", PokemonType.Water, PokemonType.Fire)
            };

        }
    }
}