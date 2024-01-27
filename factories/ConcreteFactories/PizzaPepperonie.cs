using System;

namespace factories
{

    public class PizzaPepperonie : Pizza
    {
        public PizzaPepperonie(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
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
            Pepperonie = IngredientFactory.createPepperonie();
        }
    }

}