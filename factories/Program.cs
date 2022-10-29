using System;

namespace factories
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new NYPizzaStore();

            store.OrderPizza(PizzaType.CHEESE);
        }
    }
}
