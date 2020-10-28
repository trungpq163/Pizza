using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DaNangPizzas
{
    class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "Banh pizza hy lap Danang";
            dough = "Bot mong Danang"; // thin
            sauce = "Sot ot Danang";
            toppings.Add("Ca` chua");
            toppings.Add("Khoai tay");
        }
    }
}
