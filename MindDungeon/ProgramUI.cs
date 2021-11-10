using MindDungeon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDungeon
{
    public class ProgramUI
    {
        public static void Run()
        {
            Player player = new Player();

            Console.WriteLine("=====WELCOME TO THE MIND DUNGEON===");

            Console.WriteLine("First we need your characters name, hit enter when you're done...:");
            player.name = Console.ReadLine(); 

        }
    }
}
