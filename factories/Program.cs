using System;
using factories.Chicago;
using factories.NY;

namespace factories
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStoreLocator locator = new PizzaStoreLocator();
            
            PizzaStore ny = locator.GetPizzaStore(Locations.NewYork);

            ny.OrderPizza(PizzaType.CHEESE);

            ny.OrderPizza(PizzaType.VEGGIE);


            PizzaStore chicago = locator.GetPizzaStore(Locations.Chicago);

            chicago.OrderPizza(PizzaType.PEPPERONIE);

            chicago.OrderPizza(PizzaType.CLAM);
            
        }
        
    }
}
