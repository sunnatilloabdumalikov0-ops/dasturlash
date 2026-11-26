
using System;

class Program
{
    static void Main()
    {
        int[] sonlar = { 12, 5, 8, 17, 20, 3, 14, 9 };

        Console.WriteLine("Juft sonlar:");

        foreach (int son in sonlar)
        {
            if (son % 2 == 0)
            {
                Console.WriteLine(son);
            }
        }
    }
}
