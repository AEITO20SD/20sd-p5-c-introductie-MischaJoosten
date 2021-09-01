using System;

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

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[ i, j ]);
                }
            }
        }
    }
}