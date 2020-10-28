using PizzaStore.Stores;
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
            Console.WriteLine("");
            Console.WriteLine("                          Pizza Store                        ");
            Console.WriteLine("\n0. Chon cua hang`");
            Console.WriteLine("\n1. Random cua hang?");
            Console.WriteLine("\n2. Thoat?");
            Console.WriteLine("__________________________");
            Console.Write(">> ");
        }

        static void DisplayChooseStore()
        {
            Console.WriteLine("Ban muon chon cua hang nao` de dat banh pizza?"
                + "\n\n" + "\t0. DalatStore" + "\t" + "1. DanangStore" + "\t" + "2. HCMStore");
        }

        static void DisplayChooseTypePizza()
        {
            Console.WriteLine("Ban muon dat banh pizza loai nao?"
                            + "\n\n" + "\t0. CheesePizza" + "\t1. GreekPizza" + "\t2 PepperoniPizza");
        }

        static void HandleChooseTypePizza(string typePizza, PizzaStore pizzaStore)
        {
            if (typePizza == "0" || typePizza == "CheesePizza")
            {
                pizzaStore.OrderPizza("cheese");
            }

            if (typePizza == "1" || typePizza == "GreekPizza")
            {
                pizzaStore.OrderPizza("greek");
            }

            if (typePizza == "2" || typePizza == "PepperoniPizza")
            {
                pizzaStore.OrderPizza("pepperoni");

            }
        }

        static void HandleChooseStore(String store)
        {
            PizzaStore pizzaStore;
            if (store == "0" || store == "dalat" || store == "DalatStore")
            {
                pizzaStore = new DalatPizzaStore();
                DisplayChooseTypePizza();

                string typePizza = Console.ReadLine();
                HandleChooseTypePizza(typePizza, pizzaStore);
            }

            if (store == "1" || store == "danang" || store == "DanangStore")
            {
                pizzaStore = new DanangPizzaStore();
                DisplayChooseTypePizza();

                string typePizza = Console.ReadLine();
                HandleChooseTypePizza(typePizza, pizzaStore);
            }

            if (store == "2" || store == "hcm" || store == "HCMStore")
            {
                pizzaStore = new HCMPizzaStore();
                DisplayChooseTypePizza();

                string typePizza = Console.ReadLine();
                HandleChooseTypePizza(typePizza, pizzaStore);
            }
        }

        static void Main(string[] args)
        {
            DisplayMenu();

            int key = Int32.Parse(Console.ReadLine());

            switch (key)
            {
                case 0:
                    Console.WriteLine("Ban muon chon cua hang nao` de dat banh pizza?"
                + "\n\n" + "\t0. DalatStore" + "\t" + "1. DanangStore" + "\t" + "2. HCMStore");

                    string typeimport = Console.ReadLine();
                    HandleChooseStore(typeimport);
                    break;
                default:
                    return;
            }
        }
    }
}
