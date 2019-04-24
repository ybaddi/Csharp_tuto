using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day1
{
    class Example3
    {
        static void Main3(string[] args)
        {
            double x = 4;
            double y = 5;

            Console.WriteLine("5+4 = {0}",
                GetFirstSum(x, y));

            Console.WriteLine("x => {0}",
               x);
            Console.WriteLine("y => {0}",
               y);

            // OUT PARAM
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("solution => {0}",
              solution);

            // ref param

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("num1 => {0}",
               num1);
            Console.WriteLine("num2 => {0}",
               num2);

            Swap(ref num1, ref num2);
            Console.WriteLine("num1 => {0}",
               num1);
            Console.WriteLine("num2 => {0}",
               num2);
            ////

            Console.WriteLine("5+4 = {0}",
                GetSecondSum(ref x, ref y));

            Console.WriteLine("x => {0}",
               x);
            Console.WriteLine("y => {0}",
               y);

            // function sum with many params
            // GetSum(1,2)
            // GetSum(1,2,3,4)
            // GetSum(1,2,3,4,5,6)
            Console.WriteLine(GetSum(1, 2));
            Console.WriteLine(GetSum(1, 2, 3, 4));
            Console.WriteLine(GetSum(1, 2, 3, 4, 5, 6));

            PrintInfo("ahmed", age: 18);
            PrintInfo(age: 18, name:"aymen");

            // function param with conversion
            double sum = GetSum("1", "2");
            double sum1 = GetSum();
            double sum2 = GetSum(4,5);
            double sum3 = GetSum(4);
            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            // ENUM
            color c = color.Orange;
            PrintColor(c);


            // exception

            double num4 = 5;
            double num5 = 0;
            try {
                Console.WriteLine("5/0 = {0}",
                    Dodivision(num4, num5));
            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("you are traying to divide by zero attention");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }

            


            Console.ReadLine();
        }

        private static double Dodivision(double num4, double num5)
        {
            if (num5 == 0)
            {
                throw new System.DivideByZeroException();
            }
            return num4 / num5;
        }

        private static void PrintColor(color c)
        {
            Console.WriteLine("the color is {0} " +
                "with the code {1}", c, (int)c);
        }

        enum color : byte
        {
            Orange = 5,
            Blue = 1,
            Red = 2,
            Yellow =3 
        }

        private static double GetSum(string v1 = "1", string v2="2")
        {
            double v1db = Convert.ToDouble(v1);
            double v2db = Convert.ToDouble(v2);
            return v1db + v2db;
        }

        private static double GetSum(double v1 , double v2 = 2)
        {
            
            return v1 + v2;
        }

        private static void PrintInfo(string name, int age) {
            Console.WriteLine("name is {0} and age is {1}",
                name, age);
        }

        private static int GetSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
                sum += item;
            return sum;
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private static void DoubleIt(int v, out int solution)
        {
            solution = v * 2;
        }

        private static double GetFirstSum(double x, double y)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        private static double GetSecondSum(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        } 
    }
}
