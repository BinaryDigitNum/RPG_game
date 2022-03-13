using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RPG_game
{
    internal class Game
    {
        private List<Character> Enemies;
        private Player CurrentPlayer;
        private Character CurrentEnemy;
        public Game()
        {
            Ant MrAngry = new Ant("Mr Angry", 10, ConsoleColor.DarkRed, 4);
            Bee KillerQueen = new Bee("Killer Queen", 15, ConsoleColor.DarkYellow, true);
            CurrentPlayer = new Player("Kevin", 20, ConsoleColor.DarkCyan);

            // Polymorphism in action !
            Enemies = new List<Character>() { MrAngry, KillerQueen };
        }

        public void Run()
        {
            WriteLine("=== Welcome from RPG game ===");
            CurrentEnemy = Enemies[0];
            while (true)
            {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();
                WriteLine();
                CurrentPlayer.Fight(CurrentEnemy);
                WaitForKey();

                // Round 2
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                CurrentPlayer.Fight(CurrentEnemy);
                WaitForKey();

                // Enemy turn
                Clear();

                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                CurrentEnemy.Fight(CurrentPlayer);

                WaitForKey();
                Clear();
            }

        }

        private void WaitForKey()
        {
            WriteLine("Press any key ...");
            ReadKey(true);
        }
    }
}