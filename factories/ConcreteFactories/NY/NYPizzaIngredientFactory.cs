using System;
using factories;

namespace factories.NY
{
    // Abstract factory
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        // Factory method
        public Clam createClam()
        {
            return new FreshClaim();
        }

        // Factory method
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        // Factory method
        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        // Factory method
        public Pepperonie createPepperonie()
        {
            return new SlicedPepperonie();
        }

        // Factory method
        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        // Factory method
        public Veggie[] createVeggies()
        {
            return new Veggie[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }


    public class ThinCrustDough : Dough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Adding thin crust Dought...");
        }
    }

    public class ReggianoCheese : Cheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Adding reggiano Cheese...");
        }
    }

    public class MarinaraSauce : Sauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Adding marinara Sauce...");
        }
    }

    public class SlicedPepperonie : Pepperonie
    {

        public SlicedPepperonie()
        {
            Console.WriteLine("Adding sliced Pepperonie...");
        }
    }

    public class FreshClaim : Clam
    {
        public FreshClaim()
        {
            Console.WriteLine("Adding fresh Claims...");
        }
    }
}
