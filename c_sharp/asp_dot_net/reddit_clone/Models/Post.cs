using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace reddit_clone.Models
{
	public class Post
	{

		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public int Score { get; set; }
		public string Description { get; set; }
		public User Creator { get; set; }

		public Post(string title, int score, string description)
		{
			Title = title;
			Score = score;
			Description = description;
		}

		public DateTime GetTime()
		{
			DateTime now = DateTime.Now;

			return now;
		}
	}
}
