using System;
using System.Collections.Generic;

namespace template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck> {
                new Duck(1, "small"),
                new Duck(10, "big"),
                new Duck(5, "middle"),
                new Duck(6, "over middle")
            };

            Console.WriteLine("Before sort: ");

            foreach (var d in ducks)
                Console.WriteLine(d.GetName());
            
            ducks.Sort();

            Console.WriteLine("\n After sort: ");

            foreach (var d in ducks)
                Console.WriteLine(d.GetName());

        }
    }
}
