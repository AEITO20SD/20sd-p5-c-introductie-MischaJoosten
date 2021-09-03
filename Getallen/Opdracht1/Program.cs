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

        private static int Som(int getal1, int getal2) // Verwacht een input van getal1 en getal2
        {
            return getal1 + getal2; // Geeft de waarden van getal 1 en 2 terug maar doet ze eerst bij elkaar
        }

        private static int Verschil(int getal1, int getal2) // Verwacht een input van getal1 en getal2
        {
            return getal1 - getal2; // Geeft de waarden van getal 1 en 2 terug maar haalt ze eerst van elkaar af
        }

        private static int Product(int getal1, int getal2) // Verwacht een input van getal1 en getal2
        {
            return getal1 * getal2; // Geeft de waarden van getal 1 en 2 terug maar vermenigvuldigt ze eerst
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Voer 2 getallen in"); // Vraagt om 2 getallen in te vullen
            int getal1 = Leesgeheelgetal(); // Vraagt of er iets is ingevuld
            int getal2 = Leesgeheelgetal(); // Vraagt of er iets is ingevuld
            // uitkomst som tonen
            int uitkomstsom = Som(getal1, getal2); // Vraagt naar de uitkomst
            Console.WriteLine($"De som van {getal1} en {getal2} is {uitkomstsom}"); // Weergeeft de uitkomst

            int uitkomstverschil = Verschil(getal1, getal2); // Vraagt naar de uitkomst
            Console.WriteLine($"Het verschil van {getal1} en {getal2} is {uitkomstverschil}"); // Weergeeft de uitkomst

            int uitkomstproduct = Product(getal1, getal2); // Vraagt naar de uitkomst
            Console.WriteLine($"Het product van {getal1} en {getal2} is {uitkomstproduct}"); // Weergeeft de uitkomst
        }
    }
}
