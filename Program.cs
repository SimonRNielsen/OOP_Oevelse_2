using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Highscoresystem data
            HighscoreList.AddScore(new Score("Simon", 1000));
            HighscoreList.AddScore(new Score("Simon", 2000));
            HighscoreList.AddScore(new Score("Simon", 3000));
            HighscoreList.AddScore(new Score("Simon", 4000));
            HighscoreList.AddScore(new Score("Simon", 5000));
            HighscoreList.AddScore(new Score("Simon", 6000));
            HighscoreList.AddScore(new Score("Simon", 7000));
            HighscoreList.AddScore(new Score("Simon", 8000));
            HighscoreList.AddScore(new Score("Simon", 9000));
            HighscoreList.AddScore(new Score("Simon", 10000));
            HighscoreList.AddScore(new Score("Simon", 11000));
            HighscoreList.AddScore(new Score("Simon", 12000));
            HighscoreList.PrintToScreen();
            Console.WriteLine();
            Score myScore = new Score("Simon", 42);
            Console.WriteLine(myScore);
            */

            Zoo simonsZoo = new Zoo();
            simonsZoo.AddAnimal(new Tiger("Misser", 50, 4, 7, 42));
            simonsZoo.AddAnimal(new Parrot("Pip", 10, 2, 40, 10, true));
            simonsZoo.AddAnimal(new Parrot("Hans", 10, 2, 40, 10, true));
            simonsZoo.AddAnimal(new Parrot("Tweety", 10, 2, 40, 10, true));
            simonsZoo.Feed(simonsZoo.cage[0]);

            Console.ReadKey();
        }
    }
}
