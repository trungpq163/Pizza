using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // Banh pizza peperoni
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "Banh pizza pepperoni";
            dough = "Bot day`"; // thick
            sauce = "Sot ngot";
            toppings.Add("Ca chua");
        }
    }
}
