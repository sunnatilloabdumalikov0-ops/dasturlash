
using System;

class Program
{
    static double Ortacha(params int[] sonlar)
    {
        int yigindi = 0;

        foreach (int son in sonlar)
        {
            yigindi += son;
        }

        return (double)yigindi / sonlar.Length;
    }

    static void Main()
    {
        double natija = Ortacha(10, 20, 30, 40, 50);

        Console.WriteLine("O'rtacha: " + natija);
    }
}
