using System;

namespace Strategy2
{

    public abstract class Character
    {

        private IWeaponBehavior weaponBehavior { get; set; }

        public Character()
        {

        }

        public void Fight()
        {
            weaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            weaponBehavior = weapon;
        }
    }

    public class Knight : Character
    {
        public Knight(): base() {

        }
    }

    public class Troll : Character
    {
        public Troll(): base() {

        }
    }
}