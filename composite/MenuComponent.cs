using System;
using System.Collections.Generic;

namespace composite
{


    public abstract class MenuComponent
    {

        public virtual void Add(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }


    public class Menu : MenuComponent
    {
        public string Name { get; set; }

        private List<MenuComponent> menuItems = new List<MenuComponent>();

        public Menu(string name)
        {
            Name = name;
        }

        public override void Add(MenuComponent component)
        {
            menuItems.Add(component);
        }
        
        public override void Remove(MenuComponent component)
        {
            menuItems.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Menu: {Name}: ");

            foreach (var i in menuItems)
                i.Print();
        }
    }

    public class MenuItem : MenuComponent
    {

        public string Name { get; set; }

        public int Price { get; set; }

        public MenuItem(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine($"Item: {Name} - Price {Price}");
        }
    }

}