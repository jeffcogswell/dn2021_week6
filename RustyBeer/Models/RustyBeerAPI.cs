using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RustyBeer.Models
{

	public class StylesResponse
	{
		public string name { get; set; }
		public int ibu_min { get; set; }
		public int ibu_max { get; set; }
		public string description { get; set; }
	}

	public class HopsResponse
	{
		public string name { get; set; }
		public List<string> purpose { get; set; }
		public string country { get; set; }
		public string description { get; set; }
	}

	public class RustyBeerAPI
	{
		private static HttpClient _realClient = null;
		public static HttpClient MyHttp
		{
			get
			{
				if (_realClient == null)
				{
					_realClient = new HttpClient();
					_realClient.BaseAddress = new Uri("https://rustybeer.herokuapp.com/");

				}
				return _realClient;
			}
		}

		public static async Task<List<StylesResponse>> SearchStylesByIbu(int ibu)
		{
			var connection = await MyHttp.GetAsync($"styles?ibu={ibu}");
			List<StylesResponse> styles =
				await connection.Content.ReadAsAsync<List<StylesResponse>>();
			return styles;
		}

		public static async Task<StylesResponse> SearchStylesByName(string name)
		{
			var connection = await MyHttp.GetAsync($"styles?name={name}");
			List<StylesResponse> styles =
				await connection.Content.ReadAsAsync<List<StylesResponse>>();
			if (styles.Count > 0)
			{
				return styles[0];
			}
			else
			{
				return null;
			}
		}

		public static async Task<List<HopsResponse>> SearchHopsByCountry(string country)
		{
			var connection = await MyHttp.GetAsync($"hops?country={country}");
			List<HopsResponse> hops =
				await connection.Content.ReadAsAsync<List<HopsResponse>>();
			return hops;
		}
	}
}
