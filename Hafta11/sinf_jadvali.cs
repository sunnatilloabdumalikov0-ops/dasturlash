
using System;

class Program
{
    static void Main()
    {
        int[,] baholar =
        {
            { 80, 90, 70 },
            { 60, 85, 75 },
            { 90, 95, 80 },
            { 70, 75, 85 }
        };

        int qator = baholar.GetLength(0);
        int ustun = baholar.GetLength(1);

        for (int j = 0; j < ustun; j++)
        {
            int yigindi = 0;

            for (int i = 0; i < qator; i++)
            {
                yigindi += baholar[i, j];
            }

            double ortacha = (double)yigindi / qator;

            Console.WriteLine(
                (j + 1) + "-fan o'rtachasi: " + ortacha);
        }
    }
}
