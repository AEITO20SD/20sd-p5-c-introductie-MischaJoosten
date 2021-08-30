using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zin = new string[3];

            string[] zin2 = { "Peter", "is", "de", "broer", "van", "Hans" };

            
            foreach (var woord in zin2)
            {
                Console.Write(woord + " ");
            }
            Console.WriteLine();
            zin2[0] = "Hans";
            zin2[5] = "Peter";
            foreach (var woord2 in zin2)
            {

                Console.Write(woord2 + " ");
            }
        }
    }
}
