using System;

namespace pa2_jnnorred_1Updated
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay game = new GamePlay();
            Menus menu = new Menus();
            menu.Instructions(); 
            int exit = 0; 
            while (exit != 2)
            {
                exit = game.Play(); 
            }
        }
    }
}
