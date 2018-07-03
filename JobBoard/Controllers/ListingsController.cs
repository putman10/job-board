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
        [HttpPost("/dew")]
        public ActionResult Results()
        {
            Listings newListings = new Listings();
            newListings.SetTitle(Request.Form["job-title"]);
            newListings.SetDescription(Request.Form["job-description"]);
            newListings.SetContactName(Request.Form["job-contact-name"]);
            newListings.SetContactEmail(Request.Form["job-contact-email"]);
            newListings.SetContactPhone(Request.Form["job-contact-phone"]);
            newListings.UpdateList();
            return View(newListings.GetList());
        }
    }
}
