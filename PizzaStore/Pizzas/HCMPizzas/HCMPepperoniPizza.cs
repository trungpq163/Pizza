using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.HCMPizzas
{
    class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "Banh pizza pepperoni HCM";
            dough = "Bot day` HCM"; // thick
            sauce = "Sot ngot HCM";
            toppings.Add("Ca chua");
        }
    }
}
