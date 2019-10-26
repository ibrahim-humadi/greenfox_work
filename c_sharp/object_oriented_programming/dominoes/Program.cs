using System;
using System.Collections.Generic;
using System.Text;

namespace dominoes
{
	class Program
	{
		static void Main(string[] args)
		{
			var dominoes = InitializeDominoes();
			int[] myArray = dominoes[0].GetValues();

			for (int i = 0; i < dominoes.Count; i++)
			{
				Console.WriteLine(dominoes[i]);
			}


		}


		public static List<Domino> InitializeDominoes()
		{
			var dominoes = new List<Domino>();
			dominoes.Add(new Domino(5, 2));
			dominoes.Add(new Domino(4, 6));
			dominoes.Add(new Domino(1, 5));
			dominoes.Add(new Domino(6, 7));
			dominoes.Add(new Domino(2, 4));
			dominoes.Add(new Domino(7, 1));
			return dominoes;


		}
	}
}