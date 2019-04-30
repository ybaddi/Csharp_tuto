using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day2
{
    class TP4
    {
        public static void Main1(string[] args)
        {
            if(args.Length == 0)
            {
                AfficherHelp();
            }
            else
            {
                string operation = args[0];
                switch (operation)
                {
                    case "addition":
                        Addition(args);
                        break;
                    case "multiplication":
                        Multiplication(args);
                        break;
                    case "moyenne":
                        Moyenne(args);
                        break;
                    default:
                        AfficherHelp();
                        break;
                }
            }
        }

        private static void Addition(string[] args)
        {
            if (args.Length != 3)
            {
                AfficherHelp();
            }
            else
            {
                double somme = 0;
                for (int i =1; i< args.Length; i++)
                {
                    double valeur;
                    if (!double.TryParse(args[i], out valeur))
                    {
                        AfficherHelp();
                        return;
                    }
                    somme += valeur;
                }
                Console.WriteLine($"Resultat de l'addition est {somme}");

            }
        }

        private static void Multiplication(string[] args)
        {
            if (args.Length != 3)
            {
                AfficherHelp();
            }
            else
            {
                double somme = 1;
                for (int i = 1; i < args.Length; i++)
                {
                    double valeur;
                    if (!double.TryParse(args[i], out valeur))
                    {
                        AfficherHelp();
                        return;
                    }
                    somme *= valeur;
                }
                Console.WriteLine($"Resultat de la multiplication est {somme}");

            }
        }

        private static void Moyenne(string[] args)
        {
            double moyenne = 0;
             double somme = 0;
                for (int i = 1; i < args.Length; i++)
                {
                    double valeur;
                    if (!double.TryParse(args[i], out valeur))
                    {
                        AfficherHelp();
                        return;
                    }
                    somme += valeur;
                }
            moyenne = somme / (args.Length - 1);
                Console.WriteLine($"Resultat de la moyenne est {moyenne}");

            
        }

        private static void AfficherHelp()
        {
            Console.WriteLine("Utilisez l'application de la maniere suivante:" +
                "\n NomProgramme addition 2 5 \n" +
                "NomProgramme multiplication 2 5 \n" +
                "NomProgramm moyen 2 5 10 11");
        }
    }
}
