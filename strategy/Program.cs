using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new AngryDuck();
            duck.SetFlyBehavior(new FlyWithWings());
            duck.SetQuackBehavior(new QuackBehavior());

            duck.Display();
            duck.Swim();
            duck.PerformeFly();
            duck.PerformeQuack();

            duck.SetFlyBehavior(new FlyNoWay());
            duck.PerformeFly();

            duck.SetQuackBehavior(new QuackMuteBehavior());
            duck.PerformeQuack();
        }
    }
}
