using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Message
	{
		[Key]
		public int Id { get; set; }
		public string Content { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
