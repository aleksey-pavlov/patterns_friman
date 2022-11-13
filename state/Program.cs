using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = new Building();


            building.GetCurrentState();

            building.NextState();

            building.GetCurrentState();

            building.NextState();

            building.GetCurrentState();

            building.NextState();

            building.GetCurrentState();
        }
    }
}
