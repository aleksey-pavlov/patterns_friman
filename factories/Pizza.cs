using System;

namespace factories
{

    public enum PizzaType
    {
        CHEESE,
        VEGGIE,
        CLAM,
        PEPPERONIE
    }

    public abstract class Pizza
    {
        protected string Name { get; set; }

        protected Dough Dought { get; set; }

        protected Sauce Sauce { get; set; }

        protected Cheese Cheese { get; set; }

        protected Clam Claim { get; set; }

        protected Veggie[] Veggies { get; set; }

        protected Pepperonie Pepperonie { get; set; }

        protected PizzaIngredientFactory IngredientFactory { get; set; }

        public Pizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pizza");
        }

        public void Box()
        {
            Console.WriteLine("Adding to box");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        // Factory method
        public abstract void Prepare();
    }

}