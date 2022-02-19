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


        // Overriding the base class method using Polymorphism

        //public override void DisplayInfo()
        //{
        //    WriteLine("Hello");
        //}

        public void Charge()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} charges forward everything which is the within {ChargeRange} inches range!");
            ResetColor();
        }
    }
}
