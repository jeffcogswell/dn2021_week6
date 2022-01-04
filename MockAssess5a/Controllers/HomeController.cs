using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssess5a.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssess5a.Controllers
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

		public IActionResult Calculator()
		{
			return View();
		}

		public IActionResult Result(Calculator calc)
		{
			//int result;
			//if (calc.operation == "Plus")
			//{
			//	result = calc.num1 + calc.num2;
			//}
			//else if (calc.operation == "Minus")
			//{
			//	result = calc.num1 - calc.num2;
			//}
			//else if (calc.operation == "Multiply")
			//{
			//	result = calc.num1 * calc.num2;
			//}
			//else
			//{
			//	result = calc.num1 / calc.num2;
			//}
			//ViewBag.result = result;
			return View(calc);
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
