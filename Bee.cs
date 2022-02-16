using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RPG_game
{
    internal class Bee : Enemy
    {
        private bool HasPoisonousStinger;
        public Bee(string name,int health,ConsoleColor color,bool poisonous)
            :base(name,health,color,ArtAssets.Bee)
        {
            HasPoisonousStinger = poisonous;
        }

        public void AirAttack()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} flies forward and attacks with its");
            if (HasPoisonousStinger) WriteLine("very deadly poisonous stinger");
            else WriteLine("non-poisonous stinger");
            ResetColor();
        }
    }
}
