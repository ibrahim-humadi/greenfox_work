﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace peer_to_peer.Models
{
	public class Message
	{
		[Key]
		public int MsgId { get; set; }
		public string Content { get; set; }
		public DateTime PostTime { get; set; }
	}
}
