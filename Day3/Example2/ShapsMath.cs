using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.Example2
{
    class ShapsMath
        {
        public static double GetArea(string v1, int v2, int v3)
        {
            if (string.Equals(v1,"rectangle", 
                StringComparison.OrdinalIgnoreCase))
            {
                return v2 * v3;
            }
            else if (string.Equals(v1, "triangle",
                StringComparison.OrdinalIgnoreCase))
            {
                return v2 * (v3/2);
            }
            else
            {
                return -1;
            }

        }

        public static double GetArea(Shap s, int v2, int v3 = 0)
        {
            if (s == Shap.rectangle)
            {
                return v2 * v3;
            }
            else if (s == Shap.triangle)
            {
                return v2 * (v3 / 2);
            }
            else if (s == Shap.circle)
            {
                return Math.PI * Math.Pow(v2, 2);  //3.14159 * v2*v2;
            }

            else
            {
                return -1;
            }

        }

        public enum Shap : byte
        {
            triangle,
            rectangle,
            circle
        }
    }

}
