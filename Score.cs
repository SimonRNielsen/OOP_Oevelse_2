using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class Score
    {
        private string name;
        private int points;

        public Score(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public int Points { get => points; set => points = value; }
        public string Name { get => name; set => name = value; }
        
        public override string ToString()
        {
            return $"{name} : {points}";
        }
        
    }
}
