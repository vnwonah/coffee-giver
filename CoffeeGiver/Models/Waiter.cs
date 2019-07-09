using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeGiver.Models
{
    public class Waiter
    {
        public Cup ProvideCup()
        {
            //gives us a new cup
            return new Cup();
        }

        public void FillCup(Cup cup)
        {
            //fills the cup
            cup.IsFilled = true;
        }
    }
}
