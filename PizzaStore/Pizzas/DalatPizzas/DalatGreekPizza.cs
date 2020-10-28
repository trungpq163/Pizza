using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DalatPizzas
{
    class DalatGreekPizza : Pizza
    {
        public DalatGreekPizza()
        {
            name = "Banh pizza hy lap Dalat";
            dough = "Bot mong Dalat"; // thin
            sauce = "Sot ot Dalat";
            toppings.Add("Ca` chua");
            toppings.Add("Khoai tay");
        }
    }
}
