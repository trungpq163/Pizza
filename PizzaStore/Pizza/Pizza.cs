using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        // chuan bi lam banh pizza
        public void Prepare()
        {
            Console.WriteLine("Chuan bi " + name);
            Console.WriteLine("Nhao bot ..." + dough);
            Console.WriteLine("Them sot ..." + sauce);
            Console.WriteLine("Them topping ...", toppings);
            toppings?
                .ForEach(
                (topping) => Console.WriteLine("\t" + topping)
            );
        }

        // nuong banh pizza
        public void Bake()
        {
            Console.WriteLine("Nuong banh " + name + " trong 30 phut");
        }

        // cat banh pizza
        public void Cut()
        {
            Console.WriteLine("Cat banh " + name);
        }

        // dong hop
        public virtual void Box()
        {
            Console.WriteLine("Dong hop " + name);
        }
    }
}
