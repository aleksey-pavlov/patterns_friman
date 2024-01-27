

namespace factories {

    public abstract class PizzaStore {

        // Template method
        public Pizza OrderPizza(PizzaType type) {

            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }

        // Factory method
        protected abstract Pizza CreatePizza(PizzaType type);
    }

}