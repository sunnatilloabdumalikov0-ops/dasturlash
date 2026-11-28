
using System;

class Program
{
    static void Main()
    {
        int tanlov;

        do
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       MENING PORTFOLIOM");
            Console.WriteLine("================================");
            Console.WriteLine("1. Parol tekshiruvchi");
            Console.WriteLine("2. Faktorial hisoblash");
            Console.WriteLine("3. Modular kalkulyator");
            Console.WriteLine("4. Men haqimda");
            Console.WriteLine("0. Chiqish");
            Console.WriteLine("================================");

            Console.Write("Tanlovni kiriting: ");
            tanlov = int.Parse(Console.ReadLine());

            switch (tanlov)
            {
                case 1:
                    Console.WriteLine("Parol tekshiruvchi loyihasi");
                    Console.WriteLine("Parol xavfsizligini tekshiradi.");
                    break;

                case 2:
                    Console.WriteLine("Faktorial loyihasi");
                    Console.WriteLine("Rekursiv va iterativ usulda hisoblaydi.");
                    break;

                case 3:
                    Console.WriteLine("Modular kalkulyator");
                    Console.WriteLine("Sonlar ustida amallar bajaradi.");
                    break;

                case 4:
                    Console.WriteLine("Men C# dasturlash tilini o'rganyapman.");
                    Console.WriteLine("Bu mening 1-semestr portfolio loyiham.");
                    break;

                case 0:
                    Console.WriteLine("Dastur yakunlandi!");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

        } while (tanlov != 0);
    }
}
