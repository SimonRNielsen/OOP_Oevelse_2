using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_2
{
    abstract class Animal
    {
        protected string name;
        protected int health;
        protected int legs;
        protected int age;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="legs"></param>
        /// <param name="age"></param>
        public Animal(string name, int health, int legs, int age)
        {
            this.name = name;
            this.health = health;
            this.legs = legs;
            this.age = age;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Eat()
        {
            Console.WriteLine("I'm eating");
        }

        public abstract void Sleep();
    }
}
