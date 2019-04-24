using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example4
{
    class Programm
    {

        public static void Main1()
        {
            Animal cat = new Animal();
            Animal cat2 = new Animal();
            Console.WriteLine("Animal number is {0}",
               Animal.NumOfAnimal);

            Console.WriteLine("Animal IdAnimal is {0}",
               cat.IdAnimal);

            Console.WriteLine("Animal IdAnimal is {0}",
               cat2.IdAnimal);

            cat.SetName("cat4Name");
            // cat.name = "cat4Name";
            Console.WriteLine("Animal name is {0}",
                cat.GetName());
            //

            cat.Sound = "miaouemiaoue";
            Console.WriteLine("Animal sound is {0}",
                cat.Sound);


            Console.WriteLine("Animal owner is {0}",
                cat.Owner);

        }
    }
}
