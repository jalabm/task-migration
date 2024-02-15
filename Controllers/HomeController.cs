using System;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.Contexts;

namespace MVC.Controllers
{
	public class HomeController: Controller
	{
		private readonly DataContext db;
		public HomeController(DataContext db)
		{
			this.db = db;
		}
		public IActionResult Index()
		{

			//var sizes = db.Sizes.ToList();
			return View();
		}
	}
}

