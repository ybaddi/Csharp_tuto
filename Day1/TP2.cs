using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day1
{
    class TP2
    {
        static void Main()
        {
            Console.WriteLine(CalculeIntersction());
        }

        static int CalculeSommeEntiers(int bornMin, int bornMax)
        {
            int result = 0;
            for(int i =bornMin; i<=bornMax; i++)
            {
                result += i;
            }
            return result;
        }

        static double CalculeMoyenEntiers(List<double> list)
        {
            double somme = 0;
            foreach (double item in list)
            {
                somme += item;
            }
            return somme / list.Count;
        }

        static int CalculeIntersction()
        {
            List<int> multiplede3 = new List<int>();
            List<int> multiplede5 = new List<int>();
            for(int i =3; i<= 100; i+=3)
            {
                multiplede3.Add(i);
            }

            for (int i = 5; i <= 100; i += 5)
            {
                multiplede5.Add(i);
            }
            int somme = 0;
            foreach(int m3 in multiplede3)
            {
                foreach (int m5 in multiplede5)
                {
                    if (m3 == m5)
                        somme += m3;
                }
            }
            return somme;
        }
    }
}
