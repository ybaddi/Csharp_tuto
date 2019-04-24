using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example1
{
    class Animal
    {
        string name;
        string sound;

        private static int numOfAnimals = 0;


        public Animal()
        {
            Console.WriteLine("this is a default constructor");
            name = "sans nom";
            sound = "sans son";
            numOfAnimals++;
        }

        public Animal(string n)
        {
            Console.WriteLine("this is a name based constructor");
            name = n;
            sound = "sans son";
            numOfAnimals++;
        } 

        public Animal(string n="sans nom", string s="sans son")
        {
            Console.WriteLine("this is a name and sound based constructor");
            name = n;
            sound = s;
            numOfAnimals++;
        }

        public int getNumOfAnimals()
        {
            return numOfAnimals;
        }



        public string GetName()
        {
            return name;
        }

        public string GetSound()
        {
            return sound;
        }
    }
}
