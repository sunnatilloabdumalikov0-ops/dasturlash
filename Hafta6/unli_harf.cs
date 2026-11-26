
using System;

class Program
{
    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string matn = Console.ReadLine().ToLower();

        int sanoq = 0;

        foreach (char harf in matn)
        {
            if (char.IsLetter(harf) &&
                "aeiouo'".Contains(harf))
            {
                sanoq++;
            }
        }

        Console.WriteLine("Unli harflar soni: " + sanoq);
    }
}
