
using System;

class Program
{
    // Rekursiv usul
    static long Rekursiv(int n)
    {
        if (n <= 1)
            return 1;

        return n * Rekursiv(n - 1);
    }

    // Iterativ usul
    static long Iterativ(int n)
    {
        long natija = 1;

        for (int i = 1; i <= n; i++)
        {
            natija *= i;
        }

        return natija;
    }

    static void Main()
    {
        Console.Write("Son kiriting: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("0 dan 20 gacha son kiriting!");
            return;
        }

        long a = Rekursiv(n);
        long b = Iterativ(n);

        Console.WriteLine("Rekursiv natija: " + a);
        Console.WriteLine("Iterativ natija: " + b);

        if (a == b)
            Console.WriteLine("Natijalar bir xil!");
        else
            Console.WriteLine("Natijalar har xil!");
    }
}
