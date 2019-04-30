using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example5
{
    class Animal
    {
        protected string name;
        protected string sound;
        protected readonly int num = 0;

        AnimalInfo animalInfo = new AnimalInfo();

        public string Name
        {
            get { return name; }
            set {
                Console.WriteLine("set name");
                name = value; }

        }

        public string Sound
        {
            get { return sound; }
            set
            {
                Console.WriteLine("set sound");
                sound = value; }

        }
        public void SetAnimalInfo(int num, string owner)
        {
            animalInfo.Num = num;
            animalInfo.Owner = owner;
        }

        public void GetAnimalInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalInfo.Num} " +
                $"and is owner is {animalInfo.Owner}");
        }

        public Animal():this("no mane", "no sound")
        {
            Console.WriteLine("this is a default contructor");
        }

        public Animal(string n, string s)
        {
            Console.WriteLine("this is a name and sound based contructor");
            Name = n;
            sound = s;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("{0} say {1}", name, sound);
            Console.WriteLine($"{name} say {sound}");
        }

        public class AnimalHealth
        {
            public bool HealthWeight (double hight, double weight)
            {
                double cal =  weight / hight;
                if ((cal >= .18) && (cal <= .27))
                    return true;
                else return false;
            }
        }


    }
}
