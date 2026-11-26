
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int sirliSon = random.Next(1, 101);
        int taxmin;
        int urinish = 0;

        while (urinish < 7)
        {
            Console.Write("Sonni toping (1-100): ");
            taxmin = Convert.ToInt32(Console.ReadLine());

            urinish++;

            if (taxmin == sirliSon)
            {
                Console.WriteLine("Tabriklayman! Sonni topdingiz!");
                break;
            }
            else if (taxmin < sirliSon)
            {
                Console.WriteLine("Kattaroq son kiriting!");
            }
            else
            {
                Console.WriteLine("Kichikroq son kiriting!");
            }
        }

        if (urinish == 7 && taxmin != sirliSon)
        {
            Console.WriteLine("Ishdan chiqdingiz!");
            Console.WriteLine("Sirli son: " + sirliSon);
        }
    }
}
