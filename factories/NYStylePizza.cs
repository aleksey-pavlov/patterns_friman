using System;

namespace factories
{

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            var ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals(PizzaType.CHEESE))
            {
                pizza = new NYCheesePizza(ingredientFactory);
                pizza.SetName("NY pizza style");
            }

            return pizza;
        }
    }


    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {

        }

        public override void Prepare()
        {
            Console.WriteLine($"Start preparing pizza {Name}");
            this.Dought = IngredientFactory.createDough();
            this.Sauce = IngredientFactory.createSauce();
            this.Cheese = IngredientFactory.createCheese();
        }
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Clam cleateClam()
        {
            throw new System.NotImplementedException();
        }

        public Cheese createCheese()
        {
            return new NYCheese();
        }

        public Dough createDough()
        {
            return new NYDough();
        }

        public Pepperonie createPepperonie()
        {
            throw new System.NotImplementedException();
        }

        public Sauce createSauce()
        {
            return new NYSauce();
        }

        public Veggie[] createVeggies()
        {
            throw new System.NotImplementedException();
        }


        public class NYDough : Dough
        {
            public NYDough()
            {
                Console.WriteLine("Add NYDought");
            }
        }

        public class NYCheese : Cheese
        {
            public NYCheese()
            {
                Console.WriteLine("Add NYCheese");
            }
        }

        public class NYSauce : Sauce
        {
            public NYSauce()
            {
                Console.WriteLine("Add NYSauce");
            }
        }
    }


}