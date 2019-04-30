
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day4.Example4
{
    class ArrayListExample
    {
        public static void Main1()
        {
            #region Array list
            ArrayList list = new ArrayList();

            list.Add("baddi");
            list.Add(50);
            list.Add(51);
            list.Add("youssef");

            // display number of elemenet
            Console.WriteLine("Count ; {0}", list.Count);


            // capacity
            Console.WriteLine("Capacity ; {0}", list.Capacity);

            // add an array 
            ArrayList list2 = new ArrayList();
            list2.AddRange(new Object[] { "adil", "42", "aymen" });


            // add an other list
            list.AddRange(list2);

            // sort and reverse
            list2.Sort();

            list2.Reverse();

            foreach (object o in list2)
                Console.WriteLine(o);
            Console.WriteLine("###################");
            foreach (object o in list)
                Console.WriteLine(o);

            ArrayList list3 = list2.GetRange(0, 2);

            foreach (object o in list3)
                Console.WriteLine(o);

            #endregion

            #region Dict
            Dictionary<string, string> students = new Dictionary<string, string>();

            students.Add("e1", "etudiants 1");
            students.Add("e2", "etudiants 1");
            students.Add("e3", "etudiants 1");
            students.Add("e4", null);

            // display elemet
            DisplayDict(students);

            //test if exist 
            // containskey
            #endregion

            #region sortedDict

            #endregion

            #region Queue

            #endregion


            #region Stack

            #endregion
        }

        private static void DisplayDict(Dictionary<string, string> students)
        {
            foreach(KeyValuePair<string,string> item in students)
            {
                Console.WriteLine($"key {item.Key} a pour valeur {item.Value}" );
            }
        }
    }
}