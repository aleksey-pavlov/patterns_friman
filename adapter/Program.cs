using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MalardDuck();
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Turkey: ");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nDuck: ");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nTurkeyAdapter: ");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
