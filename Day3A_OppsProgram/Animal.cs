using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    abstract class Animal
    {
        // abstract method
        public abstract void makeSound();
    }
    // inheriting from abstract class
    class Dog : Animal
    {
        // provide implementation of abstract method
        public override void makeSound()
        {
            Console.WriteLine(" Dog Sound..  Bark Bark");
        }
    }
    class Pig : Animal
    {
        // provide implementation of abstract method
        public override void makeSound()
        {
            Console.WriteLine(" Pig Sound..  Wee Wee");
        }
    }
}
