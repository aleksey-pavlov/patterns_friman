using System;

namespace Strategy
{

    public interface IQuackBehavior
    {
        void Quack();
    }

    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quuuaaaackkkk!!");
        }
    }

    public class QuackMuteBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("............");
        }
    }

}