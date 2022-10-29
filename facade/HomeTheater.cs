using System;

namespace facade
{

    public interface Screen
    {
        void On();

        void Off();
        
        void SetBrightness(int val);

        void SetContrast(int val);
    }

    public interface DVDPlayer
    {
        void On();

        void Off();

        void Pause();

        void Eject();
    }

    public interface Light
    {

        void On();

        void Off();

        void SetBrightness(int val);

    }

    public interface Amplifier
    {

        void On();

        void Off();

        void SetVolume(int val);

    }


    public class SomeTheaterScreen : Screen
    {
        public void Off()
        {
            Console.WriteLine("Screen off");
        }

        public void On()
        {
            Console.WriteLine("Screen on");
        }

        public void SetBrightness(int val)
        {
            Console.WriteLine($"Screen set brightness to {val}");
        }

        public void SetContrast(int val)
        {
            Console.WriteLine($"Screen set contrast to {val}");
        }
    }

    public class SomeTheaterDVDPlayer : DVDPlayer
    {
        public void Eject()
        {
            Console.WriteLine("DVDPlayer eject disk");
        }

        public void Off()
        {
            Console.WriteLine("DVDPlayer off");
        }

        public void On()
        {
            Console.WriteLine("DVDPlayer on");
        }

        public void Pause()
        {
            Console.WriteLine("DVDPlayer to pause");
        }
    }

    public class SomeTheaterLight : Light
    {
        public void Off()
        {
            Console.WriteLine("Light off");
        }

        public void On()
        {
            Console.WriteLine("Light on");
        }

        public void SetBrightness(int val)
        {
            Console.WriteLine($"Light set brightness to {val}");
        }
    }

    public class SomeTheaterAmplifier : Amplifier
    {
        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void SetVolume(int val)
        {
            Console.WriteLine($"Amplifier set volume to {val}");
        }
    }

}