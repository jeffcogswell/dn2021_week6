using Microsoft.AspNetCore.Mvc;
using MVCDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		// Show product form: /shop/addproductform
		public IActionResult AddProductForm()
		{
			return View();
		}

		[HttpPost]
		// Add product after form is submitted: /shop/addproduct
		public IActionResult AddProduct(Item theitem)
		{
			// This is where we would add the item to the database
			Item.Items.Add(theitem);
			//return View(theitem);
			return Redirect("/");
		}

		public IActionResult DeleteItem(int id)
		{
			Item found = null;
			foreach (Item current in Item.Items)
			{
				if (current.id == id)
				{
					found = current;
				}
			}
			if (found != null)
			{
				Item.Items.Remove(found);
			}

			return Redirect("/");
			//return Content("Thank you, the item has been deleted!");
		}

		public IActionResult EditProductForm(int id)
		{
			Item found = null;
			foreach (Item current in Item.Items)
			{
				if (current.id == id)
				{
					found = current;
				}
			}

			if (found != null)
			{
				return View(found);
			}
			else
			{
				return Redirect("/");
			}
		}

		public IActionResult EditProduct(Item theitem)
		{
			foreach (Item current in Item.Items)
			{
				if (current.id == theitem.id)
				{
					current.Name = theitem.Name;
					current.Price = theitem.Price;
					break;
				}
			}
			return Redirect("/");
		}
	}
}
