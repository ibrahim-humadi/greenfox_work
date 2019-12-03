using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fox_club.Models;

namespace fox_club.Services
{
	public class Foxes
	{
		public List<Fox> foxes { get; set; }

		public Foxes()
		{
			foxes = new List<Fox>();
		}

		public void Add(Fox fox)
		{
			foxes.Add(fox);
		}

		public void Remove(Fox fox)
		{
			foxes.Remove(fox);
		}
	}

	
}
