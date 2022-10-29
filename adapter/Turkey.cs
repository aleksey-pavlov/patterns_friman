using System;

namespace adapter
{
    public interface Turkey
    {
        void Gobble();
        void Fly();
    }

    public class WildTurkey : Turkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying to short distance");
        }
    }

}