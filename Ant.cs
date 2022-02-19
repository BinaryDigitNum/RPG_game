using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RPG_game
{
    internal class Ant : Enemy
    {
        private double ChargeRange;
        public Ant(string name,int health,ConsoleColor color,double chargeRange)
            :base(name,health,color,ArtAssets.Ant)
        {
            ChargeRange = chargeRange;
        }


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

        // Generate random number between 1 to 100 and make a guess between each methods
        public override void Fight()
        {
            double randomNum = RandomGenerator.Next(1, 101);
            if(randomNum <= 75)
            {
                Bite();
            }
            else
            {
                Charge();
            }
            
            ForegroundColor = Color;
            WriteLine($"{Name} is fighting");
        }
    }
}
