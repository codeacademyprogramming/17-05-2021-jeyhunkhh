using System;
using System.Collections.Generic;
using System.Text;

namespace _240620.Zoo
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public abstract void Sleep();
        public virtual string Sound()
        {
            return "The animal makes a sound";
        }
    }

    sealed class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void Sleep()
        {
            Console.WriteLine("Dog is sleep");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void Sleep()
        {
            Console.WriteLine("Cat is sleep");
        }
    }
}
