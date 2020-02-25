using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_18___Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_18___Coffee_Shop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View(new RegisterUser());
        }

        public IActionResult SummaryPage(RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                return View(registerUser);
            }
            else
            {
                return View("RegistrationForm", registerUser);
            }
        }

        public IActionResult DisplayInfo(RegisterUser registerUser)
        {

            return View(registerUser);
        }
    }
}