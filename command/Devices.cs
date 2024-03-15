using System;

namespace command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light on");
        }

        public void Off()
        {
            Console.WriteLine("Light off");
        }
    }


    public class Conditioner
    {
        public void On()
        {
            Console.WriteLine("Conditioner on");
        }

        public void Off()
        {
            Console.WriteLine("Conditioner off");
        }
    }
}
