using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.toStringBase();
            spotty.Bark();
            Console.WriteLine("New Happiness: " + spotty.happiness);
            
            Console.WriteLine("==========================================================");

            Cat heisenberg = new Cat();
            heisenberg.name = "Heisenberg";
            heisenberg.age = 13;
            heisenberg.happiness = 0.3f;
            heisenberg.cuteness = 0.4f;
            heisenberg.meow();
            heisenberg.toStringBase();



            Console.ReadKey();

        }

        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void toStringBase() {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("****************************");

            }
        }

        class Dog : Animal
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("WUF!");
                base.happiness += 0.1f;
                
            }



        }

        class Cat : Animal
        {
            public float cuteness;

            public void meow()
            {
                Console.WriteLine("MEOW!");
            }
        }
    }
}
