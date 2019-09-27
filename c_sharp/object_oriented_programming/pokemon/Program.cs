using System;
using System.Collections.Generic;

namespace pokemon
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Pokemon> pokemonOfAsh = InitializePokemon();
			Pokemon wildPokemon = new Pokemon("Oddish", PokemonType.Leaf, PokemonType.Water);

			foreach (var item in pokemonOfAsh)
			{
				if (item.IsEffectiveAgainst(wildPokemon) == true)
				{
					Console.Write("I choose you, " + item.Name);
				}
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
