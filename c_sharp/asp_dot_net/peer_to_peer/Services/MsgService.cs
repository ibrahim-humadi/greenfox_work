using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace peer_to_peer.Services
{
	public class MsgService
	{
		public async Task<string> PostAsync(string data)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.PostAsync("http://192.168.56.1:5000/api/message/receive", new StringContent(data, Encoding.UTF8, "application/json"));

			response.EnsureSuccessStatusCode();

			return await Task.Run(() => "Hello");
		}
	}
}
