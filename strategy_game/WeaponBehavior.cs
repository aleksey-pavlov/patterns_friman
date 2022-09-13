using System;

namespace StrategyGame
{
    public interface IWeaponBehavior
    {
        void UseWeapon();
    }

    public class KnifeWeapon : IWeaponBehavior
    {
        public void UseWeapon() 
        {
            Console.WriteLine("Using knife weapon....chick chick chick");
        }
    }

    public class SwordWeapon : IWeaponBehavior 
    {
        public void UseWeapon() 
        {
            Console.WriteLine("Using sword weapon....shuhhh shuhhh");
        }
    }

    public class BowWeapon : IWeaponBehavior 
    {
        public void UseWeapon() 
        {
            Console.WriteLine("Using bow weapon....piuu piuuu");
        }
    }
}