using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Thread
	{
		public int Id { get; set; }
		public DateTime CreationDateTime { get; set; }
		public List<Message> Messages { get; set; }

		public Thread(DateTime creationDateTime)
		{
			CreationDateTime = creationDateTime;
			Messages = new List<Message>();
		}
	}
}
