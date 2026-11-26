
using System;

class Program
{
    static int Katta(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        Console.Write("Birinchi son: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ikkinchi son: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Katta son: " + Katta(a, b));
    }
}
