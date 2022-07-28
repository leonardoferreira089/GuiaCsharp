using System;

namespace ProjConsoleCalculatrice
{
    class Program
    {
        static void Main(string[] args)
        {            
            Menu();            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qu'est-ce que voulez-vous faire?");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Soustraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Quitter");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Choisissez une option: ");

            short rep = short.Parse(Console.ReadLine());

            switch (rep)
            {
                case 1: Addition(); break;
                case 2: Soustraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Valeur 1: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valeur 2: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultat = v1 + v2;
            Console.WriteLine("Le résultat de l'addition est: " + resultat);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            Recalculer();
        }

        static void Soustraction()
        {
            Console.Clear();
            Console.WriteLine("Valeur 1: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valeur 2: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultat = v1 - v2;

            Console.WriteLine("Le résultat de la soustraction est: " + resultat);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            Recalculer();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Valeur 1: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("valeur 2: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultat = v1 * v2;

            Console.WriteLine("Le résultat de la Multiplication est: " + resultat);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            Recalculer();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Valeur 1: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valeur 2: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultat = v1 / v2;

            Console.WriteLine("Le résultat de la Division est: " + resultat);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            Recalculer();
        }

        static void Recalculer()
        {
            Console.WriteLine("Voulez-vous faire un autre calcul? (y ou n)");
            string rep = Console.ReadLine().ToLower();

            if(rep == "y" || rep == "Y")
            {
                Console.Clear();
                Menu();
            }

            else if(rep == "n" || rep == "N")
            {
                System.Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Entrez un caractère valide!");
                Console.Clear();
            }
        }
    }
}
