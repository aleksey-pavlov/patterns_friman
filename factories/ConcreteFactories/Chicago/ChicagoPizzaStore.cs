using System;

namespace factories.Chicago
{

    public class ChicagoPizzaStore : PizzaStore
    {
        // Factory method
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals(PizzaType.CHEESE))
            {
                pizza = new PizzaCheese(ingredientFactory);
                pizza.SetName("Chicago Cheese Pizza");
            }
            else if (type.Equals(PizzaType.VEGGIE))
            {
                pizza = new PizzaVeggie(ingredientFactory);
                pizza.SetName("Chicago Veggie Pizza");
            }
            else if (type.Equals(PizzaType.CLAM))
            {
                pizza = new PizzaClam(ingredientFactory);
                pizza.SetName("Chicago Clam Pizza");
            }
            else if (type.Equals(PizzaType.PEPPERONIE))
            {
                pizza = new PizzaPepperonie(ingredientFactory);
                pizza.SetName("Chicago Pepperonie Pizza");
            }

            return pizza;
        }
    }
}