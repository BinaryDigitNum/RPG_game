using System;
using System.Collections.Generic;
using static System.Console;

namespace RPG_game
{
    internal class Game
    {
        private List<Enemy> Enemies;

        public Game()
        {
            // Derived classes of Enemy class
            Ant MrAngry = new Ant("Mr Angry", 100, ConsoleColor.DarkRed, 4);
            Bee KillerQueen = new Bee("Killer Queen",150,ConsoleColor.DarkYellow,true);


            // Polymorphism in action !
            // There is an implicit conversion from derived class to base class
            Enemies = new List<Enemy>() { MrAngry,KillerQueen };
        }

        public void sayHelloFriend(Enemy enemy)
        {
            if(enemy is Ant)
            {
            WriteLine("This is an ant.");

            }
            else if(enemy is Bee)
            {
                WriteLine("This is a bee");
            }
            else
            {
                WriteLine("I am your enemy");
            }
        }

        public void Run()
        {
            WriteLine("=== Welcome from RPG game ===");

            foreach(Enemy enemy in Enemies)
            {
                enemy.DisplayInfo();
                enemy.Fight();

                //WriteLine("Instance info > ");
                //WriteLine($"What is this instance ? {enemy.GetType()}");
                //WriteLine($"Is this an object ? {enemy is object}");
                //WriteLine($"Is this an enemy? {enemy is Enemy}");
                //WriteLine($"Is this an ant? {enemy is Ant}");
                //WriteLine($"Is this a bee ? {enemy is Bee}");

                //if(enemy is Ant)
                //{
                //    Ant ant = enemy as Ant;
                //    ant.Charge();
                //}else if(enemy is Bee)
                //{
                //    Bee bee = enemy as Bee;
                //    bee.AirAttack();
                //}
                sayHelloFriend(enemy);
            }


            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Press any key .... \n");
            ReadKey(true);
        }
    }
}
