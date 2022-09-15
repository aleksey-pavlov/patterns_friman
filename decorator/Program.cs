using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Espresso();
            product.SetAmount(2);
            product = new Milk(product);
            product = new Chocolate(product);

            Console.WriteLine(product.GetDescription());
            Console.WriteLine(product.Cost());
        }
    }
}
