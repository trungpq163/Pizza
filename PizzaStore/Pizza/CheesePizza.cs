using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // banh pizza vi phomai
    class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Banh pizza vi phomai";
            dough = "Bot rat mong";
            sauce = "Nuoc sot rat cay";
            toppings.Add("Dau oliu");
            toppings.Add("Phomai");
        }

        public override void Box()
        {
            Console.WriteLine(dough);
        }
    }
}
