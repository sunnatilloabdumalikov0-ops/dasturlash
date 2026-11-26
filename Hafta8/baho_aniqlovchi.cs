
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ballingizni kiriting: ");
        int ball = Convert.ToInt32(Console.ReadLine());

        if (ball >= 86 && ball <= 100)
        {
            Console.WriteLine("Baho: 5");
        }
        else if (ball >= 71 && ball <= 85)
        {
            Console.WriteLine("Baho: 4");
        }
        else if (ball >= 56 && ball <= 70)
        {
            Console.WriteLine("Baho: 3");
        }
        else if (ball >= 0 && ball <= 55)
        {
            Console.WriteLine("Baho: 2");
        }
        else
        {
            Console.WriteLine("Noto'g'ri ball kiritildi!");
        }
    }
}
