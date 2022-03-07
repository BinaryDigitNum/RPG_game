using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RPG_game
{
    internal class Ant : Character
    {
        private double ChargeRange;
        public Ant(string name,int health,ConsoleColor color,double chargeRange)
            :base(name,health,color,ArtAssets.Ant,4)
        {
            ChargeRange = chargeRange;
        }

        // Action methods for Ant class
        public void Charge()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} charges forward everything which is the within {ChargeRange} inches range!");
            ResetColor();
        }

        public void Bite()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is biting.");
        }

        public override void Fight(Character opponent)
        {
            // generate a random percentage between 0 - 100
            // 50% hits and takes damage
            // 50% misses
            double RandomPercent = RandomGenerator.Next(0, 101);
            Write($"{Name} is attacking {opponent.Name} and ");
            if (RandomPercent <= 50)
            {
                WriteLine($"hits {Damage} damage to {opponent.Name} ");
                opponent.TakeDamage(Damage);
            }
            else
            {
                WriteLine($"misses");
            }
        }

    }
}
