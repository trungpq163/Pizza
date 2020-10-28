using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DaNangPizzas
{
    class DNPepperoniPizza : Pizza
    {
        public DNPepperoniPizza()
        {
            name = "Banh pizza pepperoni Danang";
            dough = "Bot day` Danang"; // thick
            sauce = "Sot ngot Danang";
            toppings.Add("Ca chua");
        }
    }
}
