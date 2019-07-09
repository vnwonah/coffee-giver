using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeGiver.Models;

namespace CoffeeGiver.Controllers
{
    public class HomeController : Controller
    {
        private Waiter _waiter;
        public HomeController(Waiter waiter)
        {
            _waiter = waiter;
        }
        public IActionResult Index(string email = null)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return View();
            }
            else
            {
            

                //we are getting a new cup from our injected waiter
                Cup newCup = _waiter.ProvideCup();

                //our injecter waiter now fills the new cup with coffee
                _waiter.FillCup(newCup);

                //send filled cup to users email 
                return Content($"Yay! Coffee sent to {email}");
            }
        }

    }
}
