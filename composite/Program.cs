using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new Menu("MainMenu");

            var menuItem = new MenuItem("-Item", 10);

            var subMenu = new Menu("-SubMenu");

            var subMenuItem = new MenuItem("--SubMenuItem", 20);

            var subSubMenu = new Menu("--SubSubMenu");

            var subSubMenuItem = new MenuItem("---SubSubMenuItem", 50);


            mainMenu.Add(menuItem);
            mainMenu.Add(subMenu);

            subMenu.Add(subMenuItem);
            subMenu.Add(subSubMenu);
           
            subSubMenu.Add(subSubMenuItem);            


            mainMenu.Print();

        }
    }
}
