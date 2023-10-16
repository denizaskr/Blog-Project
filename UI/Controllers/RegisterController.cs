﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			return View();
		}
		

	}
}