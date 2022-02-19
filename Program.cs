using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the main logic of the application
            Game myGame = new Game();
            myGame.Run();
        }
    }
}
