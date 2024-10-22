using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class HighscoreList
    {

        private static Score[] scores = new Score[10] /*{ new Score("" , 0) , new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0), new Score("", 0) }*/;
        
        public static Score[] GetScores()
        {
            return scores;
        }
        public static void AddScore(Score score)
        {
            for (int i = 0; i < scores.Length + 1; i++)
            {
                if (i == scores.Length)
                {
                    Console.WriteLine("No more room for new highscores");
                    break;
                }
                else if (GetScores() == null)
                {
                    scores[i] = score;
                    break;
                }
                /*
                else if (scores[i].Points.Equals(0))
                {
                    scores[i] = score;
                    break;
                }
                */
            }
        }
        public static void PrintToScreen()
        {
            foreach (var score in scores)
            {
                Console.WriteLine(score.Name + " " + score.Points);
            }
        }
    }
}
