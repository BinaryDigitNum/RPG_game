using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RPG_game
{
    internal class Character
    {
        public string Name { get; protected set; }
        public string TextArt {get; protected set;}
        public int Health {get; protected set;}
        public int MaxHealth {get; protected set;}
        public ConsoleColor Color { get; protected set; }
        public Random RandomGenerator {get; protected set;}
        public int Damage { get; protected set; }
        public Character(string name, int health, ConsoleColor color, string textArt,int damage)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Color = color;
            TextArt = textArt;
            Damage = damage;
            RandomGenerator = new Random();
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"---{Name}---");
            WriteLine(TextArt);
            WriteLine($"Health: {Health}");
            ResetColor();
        }

        // base class's virtual method
        public virtual void Fight(Character opponent)
        {
            WriteLine("Fighting...");
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;

            // Set health to 0 if it has exceeded the lower health limit
            // This is used to prevent health from having Nagative numbers.
            if(Health < 0)
            {
                Health = 0;
            }
        }

        public void DisplayHealthBar()
        {
            ForegroundColor = Color;
            WriteLine($"Player {Name}'s health :");
            ResetColor();

            Write("[");
            // Remaining health point
            BackgroundColor = ConsoleColor.Green;
            for(int i = 0; i < Health; i ++)
            {
                Write(" ");
            }

            // Empty health point
            BackgroundColor = ConsoleColor.Black;
            for(int i = Health; i < MaxHealth; i ++ )
            {
                Write(" ");
            }
            WriteLine ($"] ({Health}/{MaxHealth})");
        }
    }
}
