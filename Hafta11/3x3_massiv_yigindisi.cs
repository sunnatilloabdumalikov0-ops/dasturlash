
using System;

class Program
{
    static void Main()
    {
        int[,] massiv =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int yigindi = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                yigindi += massiv[i, j];
            }
        }

        Console.WriteLine("Massiv elementlari yig'indisi: " + yigindi);
    }
}
