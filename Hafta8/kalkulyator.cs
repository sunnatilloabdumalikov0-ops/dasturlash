
using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinchi sonni kiriting: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ikkinchi sonni kiriting: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Amalni kiriting (+, -, *, /): ");
        string amal = Console.ReadLine();

        switch (amal)
        {
            case "+":
                Console.WriteLine("Natija: " + (a + b));
                break;

            case "-":
                Console.WriteLine("Natija: " + (a - b));
                break;

            case "*":
                Console.WriteLine("Natija: " + (a * b));
                break;

            case "/":
                if (b != 0)
                    Console.WriteLine("Natija: " + (a / b));
                else
                    Console.WriteLine("Nolga bo'lish mumkin emas!");
                break;

            default:
                Console.WriteLine("Noto'g'ri amal!");
                break;
        }
    }
}
