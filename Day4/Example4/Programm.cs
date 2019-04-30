
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day4.Example4
{
    class Programm

    {
        public static void Main()
        {
            BDMAnage bd = new BDMAnage();
            //bd.OpenConnection();
            bd.Insert(user);
            bd.Insert();
            bd.Insert();
            bd.Update();
            bd.Delete();
            bd.Select();
            Console.WriteLine(bd.Count());
            //bd.CloseConnection();
        }
    }
}