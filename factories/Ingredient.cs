namespace factories {

    // Abstract factory witch contain Factory Methods
    public interface PizzaIngredientFactory {

        // Factory method
        Cheese createCheese();

        // Factory method
        Dough createDough();

        // Factory method
        Sauce createSauce();

        // Factory method
        Veggie[] createVeggies();

        // Factory method
        Clam cleateClam();

        // Factory method
        Pepperonie createPepperonie();
    }


    public class Cheese {}

    public class Dough {}

    public class Sauce {}

    public class Veggie {}

    public class Clam {}

    public class Pepperonie {}

}