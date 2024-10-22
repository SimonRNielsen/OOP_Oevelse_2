using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    internal class Parrot : Animal
    {
        private int agility;
        private bool canFly;

        public Parrot(string name, int health, int legs, int age, int agility, bool canFly) : base(name, health, legs, age)
        {
            base.name = name;
            base.health = health;
            base.legs = legs;
            base.age = age;
            this.agility = agility;
            this.canFly = canFly;
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public override void Sleep()
        {
            Console.WriteLine("I'm sleeping in water");
        }

        public void Talk()
        {
            Console.WriteLine("Hello");
        }
    }
}
