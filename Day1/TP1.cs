using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day1
{
    class TP1
    {
        static void Main2(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                AfficherBonWeekEnd();
            }
            else
            {
                if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                {
                    AfficherBonjour();
                }
                else
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday
                        && DateTime.Now.Hour >= 18)
                    {
                        AfficherBonWeekEnd();
                    }
                    else
                    {
                        AfficherBonsoir();
                    }
                }
            }
        }

        private static void AfficherBonWeekEnd()
        {
            Console.WriteLine("Bon Weekend " +
                Environment.UserName);
        }

        private static void AfficherBonjour()
        {
            Console.WriteLine("Bonjour " +
                Environment.UserName);
        }

        private static void AfficherBonsoir()
        {
            Console.WriteLine("Bonsoir " +
                Environment.UserName);
        }
    }
}
