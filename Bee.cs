using System;
using static System.Console;
namespace RPG_game
{
    internal class Bee : Character
    {
        private bool HasPoisonousStinger;
        public Bee(string name, int health, ConsoleColor color, bool poisonous)
            : base(name, health, color, ArtAssets.Bee, 5)
        {
            HasPoisonousStinger = poisonous;
        }

        #region Bee class's function members
        public void AirAttack()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} flies forward and attacks with its");
            if (HasPoisonousStinger)
            {
                WriteLine("very deadly poisonous stinger");
            }
            else
            {
                WriteLine("non-poisonous stinger");
            }

            ResetColor();
        }

        public void Fly()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} is flying around.");
        }
        #endregion

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
