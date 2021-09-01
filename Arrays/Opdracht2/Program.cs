using System;
using System.Linq;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int rij = 0; rij < 3; rij++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(array[rij, column] + " ");
                }
                Console.WriteLine();
            }


            //telt alles bij elkaar op
            int[] Optellen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine(Optellen.Sum());
        }
    }
}