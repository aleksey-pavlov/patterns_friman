using System;

namespace StrategyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character knight = new Knight();
            knight.SetWeapon(new SwordWeapon());

            Character troll = new Troll();
            troll.SetWeapon(new KnifeWeapon());

            troll.Fight();
            knight.Fight();

            knight.SetWeapon(new BowWeapon());
            knight.Fight();
        }
    }
}
