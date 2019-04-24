using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example3
{
    class nullable
    {
        public static void Main1()
        {
            int num = 0;
            int? num1 = null;

            if(num1 == null)
            {
                Console.WriteLine("num1 is null");
            }
            if (!num1.HasValue)
            {
                Console.WriteLine("num1 is null");
            }

            Console.ReadLine();
        }
    }
}
