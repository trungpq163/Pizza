using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;

                case "greek":
                    pizza = new GreekPizza();
                    break;

                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;

                default:
                    Console.WriteLine("Cua hang ko co loai" + type + "pizza nay");
                    return;
            }

            // chuan bi
            pizza.Prepare();
            
            // nuong banh
            pizza.Bake();
            
            // cat banh
            pizza.Cut();

            // dong hop
            pizza.Box();
        }
    }
}
