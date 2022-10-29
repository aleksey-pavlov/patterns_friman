using System;

namespace adapter
{
    public interface Duck
    {
        void Quack();
        void Fly();
    }


    public class MalardDuck : Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}