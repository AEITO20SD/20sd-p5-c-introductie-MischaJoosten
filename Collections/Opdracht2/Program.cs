using System;
using System.Collections.Generic;

namespace Opdracht2
{
    class Program
    {
        private static Dictionary<string, double> voertuigen;
        private static Queue<string> file;
        private static void Initialiseer()
        {
            voertuigen = new Dictionary<string, double>();
            file = new Queue<string>();
        }

        private static void Simuleer()
        {
            Queue<string> file = new Queue<string>();
            string tekst;
            bool doorgaan = true;
            while (doorgaan)
            {
                var keuze = HaalKeuze();
                keuze = keuze.ToLower();
                switch (keuze)
                {
                    case "stoppen":
                        tekst = Stoppen(file);
                        Console.WriteLine(tekst);
                        doorgaan = false;
                        break;
                    case "toevoegen":
                        tekst = Toevoegen(file);
                        Console.WriteLine(tekst);
                        Printen(file);
                        break;
                    case "weghalen":
                        tekst = Weghalen(file);
                        Console.WriteLine(tekst);
                        Printen(file);
                        break;
                    default:
                        break;
                }
            }
        }
    

        private static string HaalKeuze()
        {
            // Vraagt en leest welke keuze je maakt
            Console.WriteLine("Vul een keuze in");
            Console.WriteLine("Toevoegen, Weghalen, Stoppen");
            var keuze = Console.ReadLine();

            return keuze;
        }

        private static string Toevoegen(Queue<string> file)
        {
            // Hier wordt het voertuig toegevoegd
            Console.WriteLine("Kies uit: Auto, Vrachtwagen, Fiets, Bus");
            string voertuig = Console.ReadLine();
            voertuig = voertuig.ToLower();
            switch (voertuig)
            {
                case "auto":
                    file.Enqueue("Auto");
                    Console.WriteLine("Toegevoegd");
                    break;
                case "vrachtwagen":
                    file.Enqueue("Vrachtwagen");
                    Console.WriteLine("Toegevoegd");
                    break;
                case "fiets":
                    file.Enqueue("Fiets");
                    Console.WriteLine("Toegevoegd");
                    break;
                case "bus":
                    file.Enqueue("Bus");
                    Console.WriteLine("Toegevoegd");
                    break;
                default:
                    Console.WriteLine("Kies een goed voertuig");
                    break;
            }
            return "";
        }

        private static string Weghalen(Queue<string> file)
        {
            // Hier wordt voorste voertuig verwijderd
            file.Dequeue();
            return "Weggehaald";
        }

        private static string Stoppen(Queue<string> file)
        {
            // Hier stopt de app
            return "Stopt";
        }
        private static string Printen(Queue<string> file)
        {
            // Print welke voertuigen in de queue zitten en hoeveel er in zitten
            foreach (var voertuig in file)
            {
                Console.Write($"[{voertuig}]" + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Er staan {file.Count} voertuigen in de file");
            Console.WriteLine();
            
            return "";
        }
        static void Main(string[] args)
        {
            Initialiseer();
            Simuleer();
        }
    }
}
