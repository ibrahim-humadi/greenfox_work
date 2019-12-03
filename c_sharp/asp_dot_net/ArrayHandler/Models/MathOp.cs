using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayHandler.Models
{
	public enum Operation
	{
		sum,
		multiplyAll,
		multiplyElementsByTwo
	}
	public class MathOp
	{
		public int[] Numbers { get; set; } = { 1, 2, 5, 10 };
  
		[JsonProperty("what")]
		
		public Operation Operation { get; set; }
		
		public MathOp()
		{

		}
	}
}