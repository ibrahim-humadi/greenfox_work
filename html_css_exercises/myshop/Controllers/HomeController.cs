using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myshop.Models;

namespace myshop.Controllers
{
	public class HomeController : Controller
	{
		public static List<Product> products = new List<Product>()
		{
			new Product(1,"Nikes","Fancy shoes",50,5),
			new Product(2,"Airmax","ugly shoes",12,50),
			new Product(3,"Adidas","qwe shoes",123,5234)
		};

		public void AddProduct(Product product)
		{
			products.Add(product);
		}

		public void RemoveProduct(int id)
		{
			Product productToRemove = products.FirstOrDefault(p => p.Id == id);
			products.Remove(productToRemove);
		}



		public double GetRandomNumber()
		{
			System.Random randomNum = new System.Random();
			return randomNum.NextDouble() * (0 - 1000) + 1;
		}

		public IActionResult Index()
		{
			return View(products);
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
