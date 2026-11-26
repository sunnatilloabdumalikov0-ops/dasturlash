
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[] sonlar = new int[5];

        for (int i = 0; i < sonlar.Length; i++)
        {
            sonlar[i] = random.Next(1, 7);
        }

        Console.WriteLine("Tasodifiy sonlar:");

        foreach (int son in sonlar)
        {
            Console.WriteLine(son);
        }
    }
}
