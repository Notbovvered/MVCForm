using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCForm.Models;

namespace MVCForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new WebUser() { FirstName = "Joseph", LastName = "Hassan" });
        }
        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser)
        {
            //TODO: Update in DB here...
            return Content($"User {webUser.FirstName} updated!");
        }
    }
}