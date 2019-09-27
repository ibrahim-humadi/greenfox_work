using System;
using System.Collections.Generic;
using System.Text;

namespace animal
{
	class Animal
	{
		public string AnimalName { get; set; }
		public int Hunger { get; set; } = 50;
		public int Thirst { get; set; } = 50;

		public Animal(String animalName, int hunger, int thirst)
		{
			this.AnimalName = animalName;
			this.Hunger = hunger;
			this.Thirst = thirst;
		}

		public void Eat()
		{
			Hunger -= 1;
		}

		public void Drink()
		{
			Thirst -= 1;
		}

		public void Play()
		{
			Hunger += 1;
			Thirst += 1;
		}
	}
}
