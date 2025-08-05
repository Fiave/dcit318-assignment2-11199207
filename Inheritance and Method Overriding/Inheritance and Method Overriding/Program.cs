using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Random made sound.");
        }
    }

    // Derived class for Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class for cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Animal sound:");
            genericAnimal.MakeSound();

            Console.WriteLine("\nDog sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat sound:");
            cat.MakeSound();

            Console.ReadLine();
        }
    }
}
