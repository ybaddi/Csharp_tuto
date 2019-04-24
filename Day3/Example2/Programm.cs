using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example2
{
    class Programm
    {
       public static  void Main1()
        {
            Console.WriteLine("area of the Rectangle : {0}",
                ShapsMath.GetArea(ShapsMath.Shap.rectangle, 5, 6));

            Console.WriteLine("area of the Traingle : {0}",
                ShapsMath.GetArea(ShapsMath.Shap.triangle, 5, 6));
            Console.WriteLine("area of the Traingle : {0:C2}",
                ShapsMath.GetArea(ShapsMath.Shap.circle, 5));
        }
    }
}
