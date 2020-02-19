using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCForm.Models;

namespace MVCForm.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WebUser webUser)
        {
            if(ModelState.IsValid)
            {
                // Here the WebUser should be saved. Afterwards we would normally return another View, to 
                // indicate that the User has been successfully created, or redirect to another page 
            }
            return View();
        }
    }
}