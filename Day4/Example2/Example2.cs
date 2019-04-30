
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day4.Example2
{
    class Example2
    {
        delegate double DoubleIt(double val);
        public static void Main1()
        {
            // ecriture lambda
            DoubleIt db = x => x * 2;

            // lambda avec les list
            List<int> nlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var impaireList = nlist.Where(x => x % 2 != 0).ToList();

            foreach (var v in impaireList)
                Console.WriteLine(v);

            // get a rang of value with lambda 
            var rangList = nlist.Where(x => (x > 2) && (x < 8)).ToList();
            foreach (var v in rangList)
                Console.WriteLine(v);

            // lambda avec des string type
            List<string> strList = new List<string> { "baddi", "adil",
                " Aymen", "youssef" };

            var aNameStrList = strList.Where(x=> x.ToLower().Trim().StartsWith("a" )).ToList();

            foreach (var v in aNameStrList)
                Console.WriteLine(v);


        }
     }
}