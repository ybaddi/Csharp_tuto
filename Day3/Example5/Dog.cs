using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example5
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "dogsound";

        public Dog()
        {
            sound = "no sound";
        }

        public Dog(string name ="no name",
            string sound = "no sound",
            string sound2 = "No sound 2") : base(name,sound)
        {
            Sound2 = sound2;
        }

        public override void MakeSound()
        {
            Console.WriteLine("this is a makesound dog");
        }
    }
}
