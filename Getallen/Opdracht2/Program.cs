using System;

namespace Opdracht2
{
    class Program
    {
        private static int Leesgeheelgetal()
        {
            bool geldigGetal;
            int getal;
            do
            {
                string input = Console.ReadLine();
                geldigGetal = int.TryParse(input, out getal);
                if (!geldigGetal)
                {
                    Console.WriteLine("Voer een geldig getal in");
                }
            } while (!geldigGetal);
            return getal;
        }
        private static string GeefKaart(int getal)
        {
            string kaart;
            switch (getal)
            {
                case 1:
                    kaart = "ruiten";
                    break;
                case 2:
                    kaart = "harten";
                    break;
                case 3:
                    kaart = "klaver";
                    break;
                default:
                    kaart = "schoppen";
                    break;
            }
            return kaart;
        }
        static void Main(string[] args)
        {
            int getal = 0;
            do
            {
                Console.WriteLine("Kies een getal tussen 1 en 4");
                getal = Leesgeheelgetal();
            } while (getal < 1 || getal > 4);
            string kaart = GeefKaart(getal);
            Console.WriteLine($"U heeft {getal} gekozen. Uw kaart is {kaart}");
            Console.ReadLine();
        }
    }
}
