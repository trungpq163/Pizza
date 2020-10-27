using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // banh pizza kieu hy lap
    class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            name = "Banh pizza hy lap";
            dough = "Bot mong"; // thin
            sauce = "Sot ot";
            toppings.Add("Ca` chua");
            toppings.Add("Khoai tay");
        }

        public override void Box()
        {
            Console.WriteLine(name);
        }
    }
}
