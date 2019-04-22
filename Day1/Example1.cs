using System;


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
        for(i=0; i< args.Length; i++)
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


        int intValue = 10000;
        Console.WriteLine(intValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        Console.WriteLine("#####################");

        Console.Read();
    }
	
}
