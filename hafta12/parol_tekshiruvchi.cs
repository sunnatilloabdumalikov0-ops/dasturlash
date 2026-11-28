
using System;

class Program
{
    static void Main()
    {
        Console.Write("Parolni kiriting: ");
        string parol = Console.ReadLine();

        bool kattaHarf = false;
        bool kichikHarf = false;
        bool raqam = false;
        bool maxsusBelgi = false;

        foreach (char belgi in parol)
        {
            if (char.IsUpper(belgi))
                kattaHarf = true;

            if (char.IsLower(belgi))
                kichikHarf = true;

            if (char.IsDigit(belgi))
                raqam = true;

            if ("!@#$%".Contains(belgi))
                maxsusBelgi = true;
        }

        if (kattaHarf && kichikHarf &&
            raqam && maxsusBelgi && parol.Length >= 8)
        {
            Console.WriteLine("Parol kuchli!");
        }
        else
        {
            Console.WriteLine("Parol kuchsiz!");
        }
    }
}
