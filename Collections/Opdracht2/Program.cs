using System;
using System.Collections.Generic;

namespace Opdracht2
{
    class Program
    {
        private static void Initialiseer()
        {
            Dictionary<string, double> voertuigen;
            voertuigen = new Dictionary<string, double>();
            Queue<string> file;
        }

        private static void Simuleer()
        {
            Queue<string> file;
        }

        private static string HaalKeuze()
        {
            Console.WriteLine("Vul een keuze in");
            Console.WriteLine("Stoppen, Toevoegen, Weghalen");
            var keuze = Console.ReadLine();

            return keuze;
        }

        private static string Toevoegen(Queue<string> file)
        {
            // Hier wordt het voertuig toegevoegd
            Console.WriteLine("Voer een voertuig in");
            string voertuig = Console.ReadLine();
            file.Enqueue(voertuig);
            return "Toegevoegd";
        }

        private static string Weghalen(Queue<string> file)
        {
            file.Dequeue();
            return "Weggehaald";
        }

        private static string Stoppen(Queue<string> file)
        {
            return "Stopt";
        }
        private static string Printen(Queue<string> file)
        {
            foreach (var voertuig in file)
            {
                Console.Write($"[{voertuig}]" + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Er staan {file.Count} voertuigen in de file");
            Console.WriteLine();
            
            return "printen";
        }
        static void Main(string[] args)
        {
            Initialiseer();
            Simuleer();
            Queue<string> file = new Queue<string>();
            string tekst;
            var doorgaan = true;
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
    }
}
