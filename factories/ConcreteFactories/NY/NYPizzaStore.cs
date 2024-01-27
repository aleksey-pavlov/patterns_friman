using System;

namespace factories.NY
{

    public class NYPizzaStore : PizzaStore
    {
        // Factory method
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            var ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals(PizzaType.CHEESE))
            {
                pizza = new PizzaCheese(ingredientFactory);
                pizza.SetName("NY Cheese Pizza");
            }
            else if (type.Equals(PizzaType.VEGGIE))
            {
                pizza = new PizzaVeggie(ingredientFactory);
                pizza.SetName("NY Veggie Pizza");
            }
            else if (type.Equals(PizzaType.CLAM))
            {
                pizza = new PizzaClam(ingredientFactory);
                pizza.SetName("NY Clam Pizza");
            }
            else if (type.Equals(PizzaType.PEPPERONIE))
            {
                pizza = new PizzaPepperonie(ingredientFactory);
                pizza.SetName("NY Pepperonie Pizza");
            }

            return pizza;
        }
    }
}