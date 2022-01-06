using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeckOfCards.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public async Task<IActionResult> Index()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://deckofcardsapi.com/api/deck/");
			var connection = await client.GetAsync("new/shuffle/?deck_count=1 ");
			CardApiResponse thedeck = await connection.Content.ReadAsAsync<CardApiResponse>();


			var connection2 = await client.GetAsync($"{thedeck.deck_id}/draw/?count=2");
			CardApiResponse thecards = await connection2.Content.ReadAsAsync<CardApiResponse>();

			ViewBag.remaining = thecards.remaining;
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
