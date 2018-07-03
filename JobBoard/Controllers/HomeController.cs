﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
