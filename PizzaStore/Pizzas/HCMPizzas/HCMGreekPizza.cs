using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.HCMPizzas
{
    class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "Banh pizza hy lap HCM";
            dough = "Bot mong HCM"; // thin
            sauce = "Sot ot HCM";
            toppings.Add("Ca` chua");
            toppings.Add("Khoai tay");
        }
    }
}
