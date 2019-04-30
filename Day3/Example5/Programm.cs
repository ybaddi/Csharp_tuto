using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example5
{
    class Programm
    {
        public static void Main1()
        {
            Animal cat = new Animal();

            Animal cat2 = new Animal("cat2","miaoue");

            Animal cat3 = new Animal()
            {
                Name = "cat2",
                Sound = "miaoue"
            };

            Dog dog = new Dog()
            {
                Name = "dog",
                Sound = "sound",
                Sound2 = "sound2"
                };
            dog.Name = "dog name";
            dog.Sound = "dog sound";

            dog.MakeSound();

            // test of inner class 
            Animal.AnimalHealth getHelth = new Animal.AnimalHealth();
            Console.WriteLine("is my animal healty : {0}",
                getHelth.HealthWeight(190,50));

            // test include class
            cat.SetAnimalInfo(1234,"youssef");
            cat2.SetAnimalInfo(1234, "adil");

            dog.SetAnimalInfo(123456, "aymen");
            dog.GetAnimalInfo();

        }
        }
}
