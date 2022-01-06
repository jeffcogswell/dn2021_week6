using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheDog.Models
{

	public class BreedImage
	{
		public string id { get; set; }
		public string url { get; set; }
	}

	public class Breed
	{
		public int id { get; set; }
		public string name { get; set; }
		public string temperament { get; set; }
		public BreedImage image { get; set; }
	}

	public class DogAPI
	{

		private static HttpClient _realClient = null;
		public static HttpClient MyHttp
		{
			get
			{
				if (_realClient == null)
				{
					_realClient = new HttpClient();
					_realClient.BaseAddress = new Uri("https://api.thedogapi.com/v1/");
					_realClient.DefaultRequestHeaders.Add("x-api-key",
						"9a576995-4641-4b6b-9026-d14cf814ea57");
				}
				return _realClient;
			}
		}

		public static async Task<List<Breed>> GetBreeds(int count)
		{
			var connection = await MyHttp.GetAsync($"breeds?limit={count}");
			List<Breed> breeds = await connection.Content.ReadAsAsync<List<Breed>>();
			return breeds;
		}
	}
}
