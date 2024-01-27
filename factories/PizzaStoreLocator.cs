

using System;
using factories.Chicago;
using factories.NY;

namespace factories
{

    public enum Locations
    {
        NewYork,
        Chicago
    }

    public class PizzaStoreLocator
    {
        public PizzaStore GetPizzaStore(Locations location)
        {

            Console.WriteLine("#############################");
            Console.WriteLine($"Searchin store in {location} ");

            if (location.Equals(Locations.NewYork))
            {
                return new NYPizzaStore();
            }
            else if (location.Equals(Locations.Chicago))
            {
                return new ChicagoPizzaStore();
            }

            throw new ArgumentException("Invalid value of argument 'location'");

        }
    }

}