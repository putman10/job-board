using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobBoard.Controllers
{
    public class ListingsController : Controller
    {
        [HttpGet("/listings")]
        public IActionResult Index()
        {
            Listings newListings = new Listings();
            newListings.SetTitle(Request.Query["job-title"]);
            newListings.SetDescription(Request.Query["job-description"]);
            newListings.SetContactName(Request.Query["job-contact-name"]);
            newListings.SetContactEmail(Request.Query["job-contact-email"]);
            newListings.SetContactPhone(Request.Query["job-contact-phone"]);
            newListings.UpdateList();
            return View(newListings.GetList());
        }
    }
}
