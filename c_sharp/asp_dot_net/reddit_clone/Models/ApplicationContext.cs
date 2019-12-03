using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reddit_clone.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Post> Posts { get; set; }
		public DbSet<User> User { get; set; }


		public ApplicationContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasMany(u => u.Posts);
		}

	}
}