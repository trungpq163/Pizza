using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizzas.DaNangPizzas
{
    class DNCheesePizza : Pizza
    {
        public DNCheesePizza()
        {
            name = "Banh pizza vi phomai Danang";
            dough = "Bot rat mong Danang";
            sauce = "Nuoc sot rat cay Danang";
            toppings.Add("Dau oliu");
            toppings.Add("Phomai");
        }
    }
}
