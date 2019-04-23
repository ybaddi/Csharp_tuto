using System;
using System.Globalization;


/// <summary>
/// class summary
/// on many lines
/// </summary>
public class 
	
	Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        int x;
        x = 11;
        Console.WriteLine(x);
        int x1 = 10;
        Console.WriteLine(x1);

        int ageUtilisateur = 30;
        int ageutilisateur = 20;
        Console.WriteLine(ageUtilisateur);
        Console.WriteLine(ageutilisateur);

        // nameProgramm 123 hello word
        int i = 0;
        for (i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        string argsString = string.Join(",", args);
        Console.WriteLine(argsString);

        string[] myArgs = Environment.GetCommandLineArgs();
        for (i = 0; i < myArgs.Length; i++)
        {
            Console.WriteLine(myArgs[i]);
        }

        Console.WriteLine(Environment.UserName);


        // Datatype

        // boolean
        bool isTrue = true;
        Console.WriteLine(isTrue);

        // int 32 bit
        int intValue = 10000;
        Console.WriteLine(intValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        Console.WriteLine("#####################");

        // long 64 bit
        long k;
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        // decimal 128 bits
        // with 28 digit

        decimal d = 3.14526399938784849M;
        Console.WriteLine(d);

        // double 64 avec vergule

        // float

        // byte 8-bit
        //sbyte
        // char
        // short 
        // ulong
        // ushort


        // constante
        const double prix_unitaire = 1.50;
        // prix_unitaire = 2.50; // error 

        int x2 = 0,
           y = 2,
           z = 3;

        const double
            prix_total1 = 1.5,
            prix_sub_total = 2.5;

        // les operation

        int result = 2 * 3;

        int age1 = 20;
        int age2 = 30;
        int moyen = (age1 + age2) / 2;

        // 
        int age1_1 = 20;
        int age2_1 = 30;
        int moyen_1 = (age1_1 + age2_1) / 2;
        Console.WriteLine(moyen_1);
        age2_1 = 40;
        moyen_1 = (age1_1 + age2_1) / 2;
        Console.WriteLine(moyen_1);

        // Conversion entre type
        bool bool1 = bool.Parse(args[0]);
        Console.WriteLine(bool1);

        int int1 = int.Parse("100");
        Console.WriteLine(int1);

        double double1 = double.Parse("10,12");
        Console.WriteLine(double1);

        // Date et Datetime
        DateTime dataeTime = new DateTime(1995, 12, 21);
        Console.WriteLine(" la date est : {0} et le double est" +
            " {1}", dataeTime, double1);

        Console.WriteLine("le jour de la date est : {0}", dataeTime.DayOfWeek);

        dataeTime = dataeTime.AddDays(4);
        dataeTime = dataeTime.AddMonths(4);
        dataeTime = dataeTime.AddYears(4);
        Console.WriteLine("le date est : {0}", dataeTime);


        // time
        TimeSpan timeSpan = new TimeSpan(13, 16, 22);
        Console.WriteLine("le time est : {0}", timeSpan.ToString());
        timeSpan = timeSpan.Subtract(new TimeSpan(0, 5, 0));
        Console.WriteLine("le time est : {0}", timeSpan.ToString());
        timeSpan = timeSpan.Subtract(new TimeSpan(1, 0, 0));
        Console.WriteLine("le time est : {0}", timeSpan.ToString());

        // Data Formating


        // C for currency
        var var1 = 10;
        Console.WriteLine(var1.GetType());
        Console.WriteLine("{0:C4}", var1);


        Console.WriteLine(var1.ToString("C4",
            CultureInfo.CreateSpecificCulture("en-US")));

        // P for pading with zero
        Console.WriteLine("pad with 0 : {0:d6},    {1:d4}", var1, var1);
        Console.WriteLine(var1.ToString("D6"));

        int var2 = -1995;
        Console.WriteLine(var2.ToString("D6"));

        // f for float
        float y_1 = 4.32345F;
        decimal value2 = 23.345746677M;
        Console.WriteLine("3 decimal : {0:f3}", value2);
        Console.WriteLine(value2.ToString("F3"));


        // R for  ( to check 

        // P for pourcentage
        double value3 = 2.34567;
        Console.WriteLine("  : {0:P3}", value3);


        // hex format
        int value4 = 0x2054e;
        Console.WriteLine(value4.ToString("x"));
        Console.WriteLine(value4.ToString("x8"));


        int value5 = 123456789;
        Console.WriteLine(value5.ToString("X"));
        Console.WriteLine(value5.ToString("X2"));

        // string
        string valuestring = "this is a string";
        Console.WriteLine(valuestring.Length);

        // indexof
        //Remove
        //substring
        //insert
        //Replace
        //compare
        // equals
        //padgirht
        //trim
        // tolwer
        //toupper
        //format

        // null
        int? x_1_1 = null;
        Console.WriteLine(x_1_1 ?? 50);
        Console.Read();
    }

}
