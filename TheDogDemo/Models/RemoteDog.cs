using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheDogDemo.Models
{

	public class SpeciesImage
	{
		public int id { get; set; }
		public string url { get; set; }
	}

	public class Species
	{
		public int id { get; set; }
		public string name { get; set; }
		public string bred_for { get; set; }
		public string origin { get; set; }
		public SpeciesImage image { get; set; }
	}

	public class RemoteDog
	{
		// Step 1: Install the webapi.client library

		// Step 2: Create the singleton HttpClient instance. (Be sure to add the using System.Net.Http line up above.)

		private static HttpClient _http = null; // Internal storage. Do not use directly.
		private static HttpClient Http
		{
			get
			{
				if (_http == null)
				{
					_http = new HttpClient();
					_http.BaseAddress = new Uri("https://api.thedogapi.com/v1");
					_http.DefaultRequestHeaders.Add("x-api-key", "9a576995-4641-4b6b-9026-d14cf814ea57");
				}
				return _http;
			}
		}

		public static async Task<List<Species>> GetTen()
		{
			var connection = await Http.GetAsync("breeds");
			List<Species> dogs = await connection.Content.ReadAsAsync<List<Species>>();
			return dogs;
		}
	}
}
