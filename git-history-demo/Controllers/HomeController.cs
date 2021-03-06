﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using git_history_demo.Models;

namespace git_history_demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // C6 on feature1
            return View();
        }

        public IActionResult About()
        {
            // C7 on hotfix
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
