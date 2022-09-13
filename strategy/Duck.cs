using System;

namespace Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior { get; set; }

        private IQuackBehavior quackBehavior { get; set; }

        public Duck()
        {

        }

        public void Swim()
        {
            Console.WriteLine("I Swiming.....");
        }

        public abstract void Display();

        public void PerformeQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformeFly()
        {
            flyBehavior.Fly();
        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            quackBehavior = behavior;
        }

        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            flyBehavior = behavior;
        }
    }

    public class AngryDuck : Duck
    {
        public AngryDuck() : base()
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("Hi. I am angry duck!");
        }
    }
}