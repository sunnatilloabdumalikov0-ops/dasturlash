
using System;

class Program
{
    static void Main()
    {
        int[] vazifalar = new int[7];

        string[] kunlar =
        {
            "Dushanba",
            "Seshanba",
            "Chorshanba",
            "Payshanba",
            "Juma",
            "Shanba",
            "Yakshanba"
        };

        for (int i = 0; i < vazifalar.Length; i++)
        {
            Console.Write(kunlar[i] + " vazifalari soni: ");
            vazifalar[i] = Convert.ToInt32(Console.ReadLine());
        }

        int engKop = vazifalar[0];
        int kunIndex = 0;

        for (int i = 1; i < vazifalar.Length; i++)
        {
            if (vazifalar[i] > engKop)
            {
                engKop = vazifalar[i];
                kunIndex = i;
            }
        }

        Console.WriteLine("Eng ko'p vazifali kun: " + kunlar[kunIndex]);
        Console.WriteLine("Vazifalar soni: " + engKop);
    }
}
