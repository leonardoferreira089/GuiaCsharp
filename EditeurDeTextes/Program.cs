using System;
using System.IO;

namespace EditeurDeTextes
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
            Console.WriteLine("Qu'est-ce que vous voulez faire ?");
            Console.WriteLine("1 - Ouvrir le dossier?");
            Console.WriteLine("2 - Créer un nouveau fichier?");
            Console.WriteLine("0 - Sair?");

            short rep = short.Parse(Console.ReadLine());

            switch (rep)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Entrez le chemin du fichier");
            string path = Console.ReadLine();
            var file = new StreamReader(path);
            string text = file.ReadToEnd();
            Console.WriteLine(text);
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Tapez votre texte ci-dessous ! [ESC] pour sortir");
            Console.WriteLine("------------------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(text);
            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Où voulez-vous sauvegarder ? Entrez le chemin !");
            string path = Console.ReadLine();
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Le fichier {path} a été enregistré avec succès.");
            Console.ReadLine();
            Menu();
        }
    }
}
