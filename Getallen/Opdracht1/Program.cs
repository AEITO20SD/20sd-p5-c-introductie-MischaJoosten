using System;

namespace Opdracht1
{
    class Program
    {
        private static int Leesgeheelgetal()
        {
            string input = Console.ReadLine();
            int getal = int.Parse(input);
            return getal;
        }

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
            Console.WriteLine("Voer 2 getallen in");
            int getal1 = Leesgeheelgetal();
            int getal2 = Leesgeheelgetal();
            // uitkomst som tonen
            int uitkomstsom = Som(getal1, getal2);
            Console.WriteLine($"De som van {getal1} en {getal2} is {uitkomstsom}");

            int uitkomstverschil = Verschil(getal1, getal2);
            Console.WriteLine($"Het verschil van {getal1} en {getal2} is {uitkomstverschil}");

            int uitkomstproduct = Product(getal1, getal2);
            Console.WriteLine($"Het product van {getal1} en {getal2} is {uitkomstproduct}");
        }
    }
}
