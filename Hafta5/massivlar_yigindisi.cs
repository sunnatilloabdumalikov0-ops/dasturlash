
using System;

class Program
{
    static void Main()
    {
        int[] sonlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int yigindi = 0;

        for (int i = 0; i < sonlar.Length; i++)
        {
            yigindi += sonlar[i];
        }

        Console.WriteLine("Yig'indi: " + yigindi);
    }
}
