﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PharmaCoreApp02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page one.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page one.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
