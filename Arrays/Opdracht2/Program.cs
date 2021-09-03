using System;
using System.Linq;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 3] // maakt deze integer aan en checkt of het wel 3 bij 3 is
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int rij = 0; rij < 3; rij++) // zorgt voor boven naar beneden voor de lengte
            {
                for (int column = 0; column < 3; column++) // zorgt voor links naar rechts voor de lengte
                {
                    Console.Write(array[rij, column] + " "); // Print de colomn uit
                }
                Console.WriteLine(); // Voegt die enter toe
            }


            int[] Optellen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, }; // Telt alles bij elkaar op
            Console.WriteLine(Optellen.Sum()); // Print de opgetelde tekst
        }
    }
}