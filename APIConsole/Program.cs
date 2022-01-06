using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIConsole
{
	class Program
	{
		static async Task Main(string[] args)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://zoo-animal-api.herokuapp.com/");
			string response = await client.GetStringAsync("animals/rand/3");
			//client.BaseAddress = new Uri("https://www.grandcircus.co/");
			//string response = await client.GetStringAsync("blog/category/student-profiles/");
			Console.WriteLine(response);
		}
	}
}
