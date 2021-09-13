using System;
using Personen;
using System.Collections.Generic;
using static System.Console;

namespace Opdracht2
{
    class Program
    {
        private static List<Persoon> personen;

        private static void Invullen()
        {
            string voornaam = "Mischa";
            string achternaam = "Joosten";
            Persoon persoon1 = new Persoon(voornaam, achternaam);
            personen.Add(persoon1);
            persoon1.Lengte = 50;
            persoon1.Gewicht = 321.6;
        }

        private static void PersonenWeergeven()
        {
            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon.Voornaam);
                Console.WriteLine(persoon.Achternaam);
                Console.WriteLine(persoon.GeboorteDatum);
                Console.WriteLine(persoon.Lengte);
                Console.WriteLine(persoon.Gewicht);
            }
        }
        static void Main(string[] args)
        {
            personen = new List<Persoon>();
            Invullen();
            PersonenWeergeven();
        }
    }
}
