using System;

namespace decorator
{

    public abstract class Product {

        private int _amount = 1;
        
        public abstract string GetDescription();

        public abstract double Cost();

        public int GetAmount()
        {
            return _amount;
        }

        public void SetAmount(int amount)
        {
            _amount = amount;
        }
    }

    public class Espresso : Product
    {
               
        public override double Cost()
        {
            return GetAmount() * 10;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }

}