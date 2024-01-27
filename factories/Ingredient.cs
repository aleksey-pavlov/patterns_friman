using System;

namespace factories
{

    // Abstract factory witch contain Factory Methods
    public interface PizzaIngredientFactory
    {

        // Factory method
        Cheese createCheese();

        // Factory method
        Dough createDough();

        // Factory method
        Sauce createSauce();

        // Factory method
        Veggie[] createVeggies();

        // Factory method
        Clam createClam();

        // Factory method
        Pepperonie createPepperonie();
    }


    public class Cheese { }

    public class Dough { }

    public class Sauce { }

    public class Veggie { }

    public class Clam { }

    public class Pepperonie { }



    public class Onion : Veggie
    {
        public Onion()
        {
            Console.WriteLine("Adding some Onions...");
        }

    }

    public class Garlic : Veggie
    {
        public Garlic()
        {
            Console.WriteLine("Adding some Garlic...");
        }
    }

    public class Mushroom : Veggie
    {
        public Mushroom()
        {
            Console.WriteLine("Adding some Mushrooms...");
        }
    }

    public class RedPepper : Veggie
    {
        public RedPepper()
        {
            Console.WriteLine("Adding some RedPepper...");
        }
    }

}