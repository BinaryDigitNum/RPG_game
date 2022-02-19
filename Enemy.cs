using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RPG_game
{
    internal class Enemy
    {
        protected string Name, TextArt;
        protected int Health;
        protected ConsoleColor Color;
        protected Random RandomGenerator;

        public Enemy(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
            RandomGenerator = new Random();
        }

        // base class's virtual method
        public virtual void Fight()
        {
            WriteLine("Fighting...");
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"---{Name}---");
            WriteLine(TextArt);
            WriteLine($"Health: {Health}");
            ResetColor();
        }
    }
}
