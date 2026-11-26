
using System;

class Program
{
    static void Main()
    {
        int[] harorat = new int[7];

        for (int i = 0; i < harorat.Length; i++)
        {
            Console.Write((i + 1) + "-kun haroratini kiriting: ");
            harorat[i] = Convert.ToInt32(Console.ReadLine());
        }

        int engIssiq = harorat[0];
        int engSovuq = harorat[0];

        for (int i = 1; i < harorat.Length; i++)
        {
            if (harorat[i] > engIssiq)
                engIssiq = harorat[i];

            if (harorat[i] < engSovuq)
                engSovuq = harorat[i];
        }

        Console.WriteLine("Eng issiq harorat: " + engIssiq);
        Console.WriteLine("Eng sovuq harorat: " + engSovuq);
    }
}
