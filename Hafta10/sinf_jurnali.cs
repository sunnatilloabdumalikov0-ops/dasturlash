
using System;

class Program
{
    static void Main()
    {
        int[] ballar = { 80, 60, 90, 50, 70, 40, 100 };

        int yigindi = 0;
        int sanoq = 0;

        for (int i = 0; i < ballar.Length; i++)
        {
            yigindi += ballar[i];
        }

        double ortacha = (double)yigindi / ballar.Length;

        for (int i = 0; i < ballar.Length; i++)
        {
            if (ballar[i] < ortacha)
            {
                sanoq++;
            }
        }

        Console.WriteLine("O'rtacha ball: " + ortacha);
        Console.WriteLine("O'rtachadan past ball olganlar: " + sanoq);
    }
}
