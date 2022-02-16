using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    internal class Game
    {
        private Ant MrAngry;
        private Bee KillerQueen;
        public Game()
        {
            MrAngry = new Ant("Mr Angry", 100, ConsoleColor.DarkRed, 4);
            KillerQueen = new Bee("Killer Queen",150,ConsoleColor.DarkYellow,true);
        }

        public void Run()
        {
            Console.WriteLine("=== Welcome from RPG game ===");

            MrAngry.DisplayInfo();
            KillerQueen.DisplayInfo();
            MrAngry.Charge();
            KillerQueen.AirAttack();

            Console.ReadKey(true);
        }
    }
}
