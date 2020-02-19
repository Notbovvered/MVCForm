using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCForm.Models;

namespace MVCForm.Controllers
{
    public class ValidationController : Controller
    {
        

        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                return View(webUser);
        }
    }

}