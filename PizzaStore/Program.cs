using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("___Pizza Store___");
            Console.WriteLine("0. Dat hang pizza");
            Console.WriteLine("__________________________");
            Console.Write(">> ");
        }

        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza("pepperoni");
        }
    }
}
