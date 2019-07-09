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
        public IActionResult Index(string email = null)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return View();
            }
            else
            {
                //we have a new waiter to serve our request
                Waiter waiter = new Waiter();

                //we have a new cup from our new waiter
                Cup newCup = waiter.ProvideCup();

                //our waiter now fills the new cup with coffee
                waiter.FillCup(newCup);

                //send filled cup to users email 
                return Content($"Yay! Coffee sent to {email}");
            }
        }

    }
}
