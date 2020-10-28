using PizzaStore.Pizzas.DalatPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Stores
{
    class DalatPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new DalatCheesePizza();
                case "greek":
                    return new DalatGreekPizza();
                case "pepperoni":
                    return new DalatPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
