﻿using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
