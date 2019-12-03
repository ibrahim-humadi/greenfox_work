using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace reddit_clone.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string UserName { get; set; }
		public List<Post> Posts { get; set; }

		public User()
		{
			Posts = new List<Post>();
		}

		public void Add(Post post)
		{
			Posts.Add(post);
		}

		public void Remove(Post post)
		{
			Posts.Remove(post);
		}
	}
}
