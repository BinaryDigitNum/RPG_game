using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RPG_game
{
    internal class Player : Character
    {
        public Player(string name,int health,ConsoleColor color)
            :base(name,health,color,ArtAssets.Player,3)
        {

        }

        public void ThrowDirt(Character opponent)
        {
            Write("You threw some dirt to the enemy and ");
            int randomPercent = RandomGenerator.Next(0,101);
            if(randomPercent <= 80)
            {
                WriteLine("enemy got some dirt in its eyes");
                opponent.TakeDamage(3);
            }else
            {
                WriteLine("you missed.");
            }
        }

        public void ThrowRasengen(Character opponent)
        {
            Write("You threw a rasengen to the enemy and ");
            int randomPercent = RandomGenerator.Next(0, 101);
            if(randomPercent <= 50)
            {
                WriteLine("did some damage to it.");
                opponent.TakeDamage(5);
            }
            else
            {
                WriteLine("you missed.");
            }
        }

        public void UseShadowClone(Character opponent)
        {
            WriteLine("You used a shadow-clone jutsu and make the enemy vision blurry. The enemy took 1 damage from this attack.");
            opponent.TakeDamage(1);
        }


        public override void Fight(Character opponent)
        {
            ForegroundColor = Color;
            WriteLine($@"You are facing a {opponent.Name}. What would you do ?

1) Throw some dirt to the enemy eyes ( 80% chance to do 3 damage ).
2) Throw a rasengen to the enemy ( 50% chance to do 5 damage ).
3) Use a Shadow clone jutsu to make enemy vision blur for a moment ( 100% chance to do 1% damage ).
");
            ConsoleKeyInfo keyInfo = ReadKey(true);
            if(keyInfo.Key == ConsoleKey.D1)
            {
                ThrowDirt(opponent);
            }else if(keyInfo.Key == ConsoleKey.D2)
            {
                ThrowRasengen(opponent);
            }else if(keyInfo.Key == ConsoleKey.D3)
            {
                UseShadowClone(opponent);
            }else
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Invalid choice of attack. Try again!");
                ResetColor();
                // Recursion happens here
                Fight(opponent);
                return;
            }
            ResetColor();
        }
    }
}
