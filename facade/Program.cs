using System;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var screen = new SomeTheaterScreen();
            var dvd = new SomeTheaterDVDPlayer();
            var light = new SomeTheaterLight();
            var amplifier = new SomeTheaterAmplifier();

            var homeTheater = new HomeTheaterFacade(screen, dvd, light, amplifier);

            Console.WriteLine("########### Movie watching start ############");

            homeTheater.WatchMovie();

            Console.WriteLine("########### Movie watching end ############");

            homeTheater.EndMovie();
        }
    }
}
