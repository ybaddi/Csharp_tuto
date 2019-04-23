using System;
using System.Text;
using System.Globalization;

namespace Csharp_tuto.Day1
{
    class Example2
    {
        static void Main2(string[] args)
        {
            // string builder
            StringBuilder sb = new StringBuilder
            ("random text random text", 18);
            StringBuilder sb1 = new StringBuilder
            ("random text random text", 256);

            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb1);
            Console.WriteLine(sb1.Capacity);

            Console.WriteLine(sb.Length);
            Console.WriteLine(sb1.Length);

            // add text to string builder
            sb.AppendLine(@"
 more text appended");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);

            // add formated text
            double value = 1234.56789;
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            sb.AppendFormat(enUS, "best manager is : {0}", "Adil");
            Console.WriteLine(sb);

            Console.WriteLine(value.ToString("C3", enUS));

            // replace instringbuilder 
            sb.Replace("Adil", "Aymen");
            Console.WriteLine(sb);


            sb.Clear();
            sb.AppendLine(@"more text appended");

            // is Equals

            Console.WriteLine(sb.Equals(sb1));

            // insert
            sb.Insert(11, "hello");
            Console.WriteLine(sb);

            // remove
            sb.Remove(11, 5);
            Console.WriteLine(sb);

            // cast on java
            long age = 16;
            int ageInt = (int)age;

            if (age >= 16)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            bool isTrue = age >= 16 ? true : false;

            // switch

           switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("go to school");
                    break;
                default:
                    Console.WriteLine("go to work");
                    goto other;
            }
            other:
            Console.WriteLine("go to other");


            Console.ReadLine();
        }
    }
}
