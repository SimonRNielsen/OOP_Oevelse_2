using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class HighscoreList
    {

        private static Score[] scores = new Score[10];

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
                    Array.Resize<Score>(ref scores, scores.Length + 1);
                    scores[i] = score;
                    break;
                }
                else if (scores[i] == null)
                {
                    scores[i] = score;
                    break;
                }
            }
        }
        public static void PrintToScreen()
        {
            foreach (var score in scores)
            {
                if (score == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(score);
                }
            }
        }
    }
}
