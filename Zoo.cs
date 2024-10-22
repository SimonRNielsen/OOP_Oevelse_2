using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class Zoo
    {
        //Burde være public
        public Animal[] cage = new Animal[1];

        public void AddAnimal(Animal animal)
        {
            for (int i = 0; i < cage.Length + 1; i++)
            {
                if (i == cage.Length)
                {
                    Array.Resize<Animal>(ref cage, cage.Length + 1);
                    cage[i] = animal;
                    break;
                }
                else if (cage[i] == null)
                {
                    cage[i] = animal;
                    break;
                }
            }
        }

        public void Feed(Animal animal)
        {
            //foreach (var cagedAnimal in cage)
            //{
                animal.Eat();
            //}
        }
    }
}
