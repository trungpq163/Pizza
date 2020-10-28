using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.HCMPizzas
{
    class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "Banh pizza vi phomai HCM";
            dough = "Bot rat mong HCM";
            sauce = "Nuoc sot rat cay HCM";
            toppings.Add("Dau oliu");
            toppings.Add("Phomai");
        }
    }
}
