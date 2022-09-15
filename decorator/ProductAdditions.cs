using System;

namespace decorator
{

    public abstract class ProductAdditions : Product {
        
        protected Product Product;

        public ProductAdditions(Product product) {
            Product = product;
        }
    }

    public class Milk : ProductAdditions
    {
        public Milk(Product product): base(product) 
        {
            
        }

        public override double Cost()
        {
            return Product.GetAmount() * (20 + Product.Cost());
        }

        public override string GetDescription()
        {
            return Product.GetDescription() + ", Milk";
        }
    }

    public class Chocolate : ProductAdditions
    {
        public Chocolate(Product product): base(product)
        {

        }

        public override double Cost()
        {
            return Product.GetAmount() * (Product.Cost() + 34);
        }

        public override string GetDescription()
        {
            return Product.GetDescription() + ", Chocolate";
        }
    }
}