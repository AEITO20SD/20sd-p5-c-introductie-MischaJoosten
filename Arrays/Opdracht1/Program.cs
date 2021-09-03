using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zin2 = { "Peter", "is", "de", "broer", "van", "Hans" }; //Zet Peter is de broer van Hans in een string genaamt zin2

            
            foreach (var woord in zin2) // Veranderd in deze foreach zin2 naar woord en kan alleen hier worden gebruikt
            {
                Console.Write(woord + " "); // Print de woorden bij zin2 plus een spatie tussen de woorden
            }
            Console.WriteLine(); // Voegt een enter toe aan de tekst 
            zin2[0] = "Hans"; // Veranderd Peter in Hans
            zin2[5] = "Peter"; // Veranders Hans is Peter
            foreach (var woord2 in zin2) // Veranderd in deze foreach zin2 naar woord2 en kan alleen hier worden bebruikt
            {
                Console.Write(woord2 + " "); // Print de woorden van zin2 maar dan wel met Hans en Peter omgedraait.
            }
        }
    }
}
