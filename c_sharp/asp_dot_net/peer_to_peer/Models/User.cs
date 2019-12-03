using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peer_to_peer.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Username { get; set; }
		public List<Message> Messages { get; set; }

		public User()
		{
			Messages = new List<Message>();
		}

		public void Add(Message message)
		{
			Messages.Add(message);
		}

		public void Remove(Message message)
		{
			Messages.Remove(message);
		}
	}
}
