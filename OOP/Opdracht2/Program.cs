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
            Persoon persoon1 = new Persoon();
            persoon1.Voornaam = "Mischa";
            persoon1.Achternaam = "Joosten";
            persoon1.GeboorteDatum = DateTime.Now;
            personen.Add(persoon1);
        }

        private static void PersonenWeergeven()
        {
            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon.Voornaam);
                Console.WriteLine(persoon.Achternaam);
                Console.WriteLine(persoon.GeboorteDatum);
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
