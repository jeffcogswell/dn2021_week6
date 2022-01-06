using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace APIConsole2
{

	class Animal
	{
public string name { get; set; }
public string animal_type { get; set; }
public string habitat { get; set; }
public string image_link { get; set; }
public override string ToString()
{
	return $"{name} {animal_type} {habitat} {image_link}";
}
	}

	class Program
	{
		static async Task Main(string[] args)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://zoo-animal-api.herokuapp.com/");
			var response = await client.GetAsync("animals/rand/5");
			List<Animal> animals = await response.Content.ReadAsAsync<List<Animal>>();

			foreach (Animal ani in animals) {
				Console.WriteLine(ani);
			}
		}
	}
}
