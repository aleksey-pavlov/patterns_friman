using System;

namespace factories
{

    public class PizzaClam : Pizza
    {
        public PizzaClam(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {

        }

        // Factory method
        public override void Prepare()
        {
            Console.WriteLine($"##############################");
            Console.WriteLine($"Starting preparing {Name}");
            Dought = IngredientFactory.createDough();
            Sauce = IngredientFactory.createSauce();
            Cheese = IngredientFactory.createCheese();
            Claim = IngredientFactory.createClam();
            
        }
    }

}