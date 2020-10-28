using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            // chuan bi lam banh pizza
            pizza.Prepare();

            // nuong banh
            pizza.Bake();

            // cat banh 
            pizza.Cut();

            // dong hop
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
