using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Newpage()
		{
			DateTime rightnow = DateTime.Now;
			return Content(rightnow.ToString());
		}

		public IActionResult htmlpage()
		{
			DateTime rightnow = DateTime.Now;
			ViewBag.RightNow = rightnow;
			ViewBag.Message = "This is a message!";
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
