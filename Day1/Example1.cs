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

        // indexof : return index of string passed as param
        Console.WriteLine(valuestring.IndexOf("is a"));
        //Remove
        String substring1 = valuestring.Remove(10,6);
        Console.WriteLine(substring1);
        //substring
        String substring2 = valuestring.Substring(10);
        Console.WriteLine(substring2);
        //insert
        Console.WriteLine(valuestring.Insert(11, "added "));
        //Replace
        string substring3 = valuestring.Replace("is", "add");
        Console.WriteLine(substring3);
        //compare
        Console.WriteLine(string.Compare(valuestring, substring3));
        Console.WriteLine(string.Compare("baddi", "Baddi", StringComparison.OrdinalIgnoreCase));
        // equals
        Console.WriteLine(string.Equals("baddi", "Baddi", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(string.Equals("baddi", "Baddi", StringComparison.Ordinal));


        //padgirht
        string valuestring2 = "  Hello World hello world hello world hello world  ";
        String substring4 = valuestring2.Substring(17);
        Console.WriteLine(substring4.PadRight(20, '.'));

        //trim
        Console.WriteLine(valuestring2.Trim());
        // tolwer
        Console.WriteLine(valuestring2.ToLower());
        //toupper
        Console.WriteLine(valuestring2.ToUpper());
        //format
        string valuestring3 = string.Format(
            " {1}, \n {0}, {2}, et {3}", 
            "baddi", "youssef", "adil", "aymen");
        Console.WriteLine(valuestring3);

        Console.Write("Exactly what i typed");
        Console.Write("\n");
        Console.Write(@"Exactly what i typed");

        string str_1_1 = "un guillemet \" , un anti-slacsh \\, un retour a la ligne \n";
        string str_1_2 = @"un guillemet "" , un anti-slacsh \, un retour a la ligne 
            ";
        Console.Write(str_1_1);
             Console.WriteLine(str_1_2);


       // null
       int ? x_1_1 = null;
       Console.WriteLine(x_1_1 ?? 50);

        bool? isTrue_1;
        int? res = 0 ;
        int? value = null;
        if (value == null)
        {
            res = default(int);
            isTrue_1 = default(bool);
            Console.WriteLine(isTrue_1);
        }
        else res = (value < 0) ? -value : value;

        Console.WriteLine(res);

        Type t = typeof(int);
        Console.WriteLine(t);

        // Function

        SayHello();


        // arrays

        int[] arrayOfInt;

        // allocation du memoire

        int[] arrayofInt_1 = new int[10];
        arrayOfInt = new int[3];

        // allocation du memoire et initialisation
        int[] arrayOfint_2 = new int[] { 3, 4, 5, 1, 2,  6, 7, 8, 9 };

        
        // index access
        arrayOfInt[1] = 23;
        arrayOfInt[2] = 20;
        arrayOfInt[0] = 30;

        Console.WriteLine("valeur de l'index 0 est : {0}", arrayOfInt[0]);

        string[] arrayOfString = { "baddi", "youssef", "adil", "aymen" };
        var arrayOfString_2 = new[] { "baddi", "youssef", "adil", "aymen" };

        object[] arrayOfObject = { "baddi", 1, "youssef", 2 };
        Console.WriteLine("type of elemenet in index 0 is {0}",
            arrayOfObject[0].GetType());
        Console.WriteLine("type of elemenet in index 1 is {0}",
            arrayOfObject[1].GetType());

        Console.WriteLine("size od table is {0}",
            arrayOfObject.Length);

        for(int j = 0; j< arrayOfString.Length; j++)
        {
            Console.WriteLine("array {0}: value: {1}",
                j, arrayOfString[j]);
        }

        foreach (string item in arrayOfString)
        {
            Console.WriteLine("value: {0}",
                item);
        }

        // multi-dimension array
        string[,] array2dOfString = new string[2, 2]
            {{"baddi" , "youssef" },{"adil", "aymen"}};

        Console.WriteLine("value of [0,0]: {0}",
               array2dOfString.GetValue(0,1));

        for (i = 0; i < array2dOfString.GetLength(0); i++)
        {
            for (int j = 0; j < array2dOfString.GetLength(1); j++)
            {
                Console.WriteLine("array {0},{1}: value: {2}",
                    i,j, array2dOfString.GetValue(i,j));
            }
                      
        }

 // function
            PrintStringArray(array2dOfString, "foreach");
            PrintStringArray(array2dOfString, "for");

        // sort array
        PrintIntArray(arrayOfint_2, "foreach");
        Array.Sort(arrayOfint_2);
        PrintIntArray(arrayOfint_2,"foreach");

        // reverse sort
        Array.Reverse(arrayOfint_2);
        PrintIntArray(arrayOfint_2, "foreach");

        // get index of elemenet
        Console.WriteLine(" 9 at index {0}",
            Array.IndexOf(arrayOfint_2, 9));
        Console.WriteLine(" 4 at index {0}",
            Array.IndexOf(arrayOfint_2, 4));

        // sett value of index
        arrayOfint_2.SetValue(33, 5);
        PrintIntArray(arrayOfint_2, "foreach");

        //copy of tables
        int[] srcArray = { 1, 2, 3 };
        int[] dstArray = new int[3];
        int startIn = 1;
        int lenght = 2;

        Array.Copy(srcArray,startIn, dstArray,startIn,lenght);
        PrintIntArray(dstArray, "foreach");

        Array annotherArray = Array.CreateInstance(typeof(int), 20);
        //PrintIntArray(annotherArray, "foreach");
        Array annotherIntArray = Array.CreateInstance(typeof(int), 10);

        srcArray.CopyTo(annotherArray, 5);

        foreach (int var in annotherArray)
            Console.WriteLine("annother array : {0}", var);


        // find
        int[] arrayofNumber = { 1, 2, 24, 25 };
        Console.WriteLine(" > 10 : {0}",Array.Find(arrayofNumber,GT10));

        Console.Read();
    }

    private static bool GT10(int obj)
    {
        return obj > 10;
    }

    private static void PrintIntArray(int[] arrayOfint_2, string v)
    {
        if (v.Equals("foreach"))
        {
            Console.WriteLine("with foreach");
            foreach (int item in arrayOfint_2)
            {
                Console.WriteLine("value: {0}",
                    item);
            }
        }
        else
        {
            Console.WriteLine("with for");
            for (int i = 0; i < arrayOfint_2.Length; i++)
            {
                
                    Console.WriteLine("array {0}: value: {1}",
                        i, arrayOfint_2[i]);
                

            }
        }
    }

    private static void PrintStringArray(string[,] array2dOfString, string v)
    {
        if (v.Equals("foreach"))
        {
            Console.WriteLine("with foreach");
            foreach (string item in array2dOfString)
            {
                Console.WriteLine("value: {0}",
                    item);
            }
        }
        else
        {
            Console.WriteLine("with for");
            for (int i = 0; i < array2dOfString.GetLength(0); i++)
            {
                for (int j = 0; j < array2dOfString.GetLength(1); j++)
                {
                    Console.WriteLine("array {0},{1}: value: {2}",
                        i, j, array2dOfString.GetValue(i, j));
                }

            }
        }
    }

    private static void SayHello()
    {
        Console.WriteLine("veuillez saisir votre Nom : ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}", name);
    }
}
