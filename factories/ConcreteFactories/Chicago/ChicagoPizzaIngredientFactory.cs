using System;
using factories;

namespace factories.Chicago
{
    // Abstract factory
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        // Factory method
        public Clam createClam()
        {
            return new FrozenClaim();
        }

        // Factory method
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        // Factory method
        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        // Factory method
        public Pepperonie createPepperonie()
        {
            return new SolidPepperonie();
        }

        // Factory method
        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        // Factory method
        public Veggie[] createVeggies()
        {
            return new Veggie[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }


    public class ThickCrustDough : Dough
    {
        public ThickCrustDough()
        {
            Console.WriteLine("Adding thick crust Dought...");
        }
    }

    public class MozzarellaCheese : Cheese
    {
        public MozzarellaCheese()
        {
            Console.WriteLine("Adding mozzarella Cheese...");
        }
    }

    public class PlumTomatoSauce : Sauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine("Adding plum tomato Sauce...");
        }
    }

    public class SolidPepperonie : Pepperonie
    {

        public SolidPepperonie()
        {
            Console.WriteLine("Adding solid Pepperonie...");
        }
    }

    public class FrozenClaim : Clam
    {
        public FrozenClaim()
        {
            Console.WriteLine("Adding frozen Claims...");
        }
    }
}
