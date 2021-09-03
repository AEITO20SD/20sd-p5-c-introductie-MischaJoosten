using System;

namespace Opdracht1
{
    class Program
    {
        private static int Leesgeheelgetal() // Checkt of er iets is ingevuld
        {
            string input = Console.ReadLine(); // Checkt de input regel met of daar iets staat
            int getal = int.Parse(input); // Checkt of het een heel getal is
            return getal; // returnt de input bij getal
        }

        // Rekend de waarden uit met de 2 cijfers die ingevuld zijn
        private static int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private static int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;
        }

        private static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Voer 2 getallen in"); // Vraagt om 2 getallen in te vullen
            // Vraagt of er iets is ingevuld
            int getal1 = Leesgeheelgetal();
            int getal2 = Leesgeheelgetal();
            // Laat de uitkomst van de som tonen
            int uitkomstsom = Som(getal1, getal2);
            Console.WriteLine($"De som van {getal1} en {getal2} is {uitkomstsom}");
            int uitkomstverschil = Verschil(getal1, getal2);
            Console.WriteLine($"Het verschil van {getal1} en {getal2} is {uitkomstverschil}");
            int uitkomstproduct = Product(getal1, getal2);
            Console.WriteLine($"Het product van {getal1} en {getal2} is {uitkomstproduct}");
        }
    }
}
