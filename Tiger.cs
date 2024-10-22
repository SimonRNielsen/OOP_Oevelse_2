using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class Tiger : Animal
    {
        private int strength;

        public Tiger(string name, int health, int legs, int age, int strength) : base(name, health, legs, age)
        {
            base.name = name;
            base.health = health;
            base.legs = legs;
            base.age = age;
            this.strength = strength;
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a tiger and i'm eating");
        }

        public override void Sleep()
        {
            Console.WriteLine("I'm sleeping on land");
        }
    }
}
