using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
	public class ApplicationContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Message> Messages { get; set; }

		public ApplicationContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasMany(u => u.Messages);
			modelBuilder.Entity<User>().HasMany(u => u.Threads);
			modelBuilder.Entity<Thread>().HasMany(u => u.Messages);
		}
	}
}
