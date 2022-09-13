using System;

namespace Strategy
{

    public interface IFlyBehavior
    {
        void Fly();
    }


    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I Flying with wings....");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I Can't fly....");
        }
    }
}