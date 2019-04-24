using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example4
{
    class Animal
    {
        private int idAnimal;
        private string name;
        private string sound;
        private int age;
        public static int NumOfAnimal { get; set; } = 0;

        public string Owner { get; set; } = "no Owner";

        public const string caption = "this is a constant caption";

        public Animal()
        {
            name = "sans nom";
            sound = "sans son";
            NumOfAnimal++;

            Random rdm = new Random();
            idAnimal = rdm.Next(int.MinValue, int.MaxValue);
        }

        public Animal(string n = "sans nom")
        {
            name = n;
            sound = "sans son";
            NumOfAnimal++;

            Random rdm = new Random();
            idAnimal = rdm.Next(int.MinValue, int.MaxValue);
        }

        public Animal(string n = "sans nom", string s = " sans son")
        {
            name = n;
            sound = s;
            //numOfAnimal++;

            Random rdm = new Random();
            idAnimal = rdm.Next(int.MinValue, int.MaxValue);
        }

        public void SetName(string name)
        {
            // name without number
            if (!name.Any(char.IsDigit)) {
                this.name = name;
            }
            else
            {
                this.name = "sans nom";
                Console.WriteLine("given name contains number");
            }
        }

        public string GetName()
        {
            return this.name;
        }

       public int IdAnimal {
            get { return this.idAnimal; }
            set {
                this.idAnimal = value;
            }
        }

        public string Sound
        {
            get { return this.sound; }
            set
            {
                // given sound must not contains more then 10 digits
                if(value.Length > 10)
                {
                    this.sound = "no sound";
                    Console.WriteLine("given sound contains more then 10 digits");
                }
                else
                {
                    this.sound = value;
                }
                
            }
        }

        
    }
}
