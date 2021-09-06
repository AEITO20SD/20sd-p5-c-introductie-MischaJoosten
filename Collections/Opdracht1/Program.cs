using System;
using System.Collections.Generic;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stapel = new Stack<string>(); // Maakt een nieuwe stack aan
            VulStack(stapel, 5); // vraagt een invoer waarde 4 keer
            PrintStack(stapel); // print de stack
            do
            {
                Console.WriteLine("Geef een waarde op:"); // Vraagt om een waarde in tevullen
                string invoer = Console.ReadLine(); // Leest de regel die je net hebt ingevuld
                if (stapel.Contains(invoer)) // Checkt of het woord in de stapel staat
                {
                    Console.WriteLine("Dit woordt staat in de stapel");
                    if (stapel.Peek() == invoer) // Kijkt of het woord boven aan de stapel staat
                    {
                        Console.WriteLine("Het woordt staat bovenop de stapel");
                        stapel.Pop(); // Verwijderd het woord
                        PrintStack(stapel); // Print de stapel opnieuw uit
                        Console.WriteLine($"Er staan nog {stapel.Count} woorden in de stapel"); // Laat het aantal woorden in de stapel ziet
                    }
                }
                else
                {
                    Console.WriteLine("Woord staat niet in de stapel");
                }
            } while(stapel.Count > 0); // Zorgt ervoor dat het door blijft gaat tot er niks meer in staat

        }
        private static void VulStack(Stack<string> stapel, int aantal)
        {
            for (int i = 1; i < aantal; i++) // De waarde begint bij 1
            {
                Console.WriteLine($"Geef een waarde voor {i}:"); // Steld de vraag met het bijbehorende nummer
                string woord = Console.ReadLine(); // Leest of er iets is ingevuld
                stapel.Push(woord); // Zet het woord op de top van de stapel neer
            }
        }
        private static void PrintStack(Stack<string> stapel)

        {
            foreach (var woord in stapel) // Convert stapel naar var woord
            {
                Console.WriteLine(woord); // Print de stack uit
            }
        }
    }
}

