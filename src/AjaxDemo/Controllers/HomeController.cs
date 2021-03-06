﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }

        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }

        public IActionResult DisplayObject(string city, string country, int id)
        {
            Destination destination = new Destination(city, country, id);
            return Json(destination);
        }

        public IActionResult DisplayViewWithAjax()
        {
            return View();
        }
    }
}
