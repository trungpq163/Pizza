using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DalatPizzas
{
    class DalatCheesePizza : Pizza
    {
        public DalatCheesePizza()
        {
            name = "Banh pizza vi phomai Dalat";
            dough = "Bot rat mong Dalat";
            sauce = "Nuoc sot rat cay Dalat";
            toppings.Add("Dau oliu");
            toppings.Add("Phomai");
        }
    }
}
