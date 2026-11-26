
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ovqat narxini kiriting: ");
        double narx = Convert.ToDouble(Console.ReadLine());

        Console.Write("Chegirma kodini kiriting: ");
        string kod = Console.ReadLine();

        if (kod == "STUDENT10")
        {
            double chegirma = narx * 0.10;
            narx = narx - chegirma;

            Console.WriteLine("10% chegirma berildi!");
            Console.WriteLine("Chegirma: " + chegirma);
        }
        else
        {
            Console.WriteLine("Chegirma kodi noto'g'ri!");
        }

        Console.WriteLine("Yakuniy summa: " + narx);
    }
}
