using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example1
{
    class Programm
    {
        public static void Main1()
        {
            Animal a1 = new Animal();
            Console.WriteLine("Name of this animal is {0}", a1.getNumOfAnimals());
            Animal a2 = new Animal("chat");
            Console.WriteLine("Name of this animal is {0}", a2.getNumOfAnimals());
            Animal a3 = new Animal("chat","miaoue");
            Console.WriteLine("Name of this animal is {0}", a3.getNumOfAnimals());

            Console.WriteLine("Name of this animal is {0}", a1.GetName());
            Console.WriteLine("Sound of this animal is {0}", a1.GetSound());
        }
    }
}
