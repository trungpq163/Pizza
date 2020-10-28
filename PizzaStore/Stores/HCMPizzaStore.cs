using PizzaStore.Pizzas.HCMPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Stores
{
    class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HCMCheesePizza();
                case "greek":
                    return new HCMGreekPizza();
                case "pepperoni":
                    return new HCMPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
