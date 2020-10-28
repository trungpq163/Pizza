using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DalatPizzas
{
    class DalatPepperoniPizza : Pizza
    {
        public DalatPepperoniPizza()
        {
            name = "Banh pizza pepperoni Dalat";
            dough = "Bot day` Dalat"; // thick
            sauce = "Sot ngot Dalat";
            toppings.Add("Ca chua");
        }
    }
}
