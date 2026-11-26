
using System;

class Program
{
    static void Main()
    {
        int son;

        do
        {
            Console.Write("Chiqish uchun 0 kiriting: ");
            son = Convert.ToInt32(Console.ReadLine());

        } while (son != 0);

        Console.WriteLine("Dastur tugadi!");
    }
}
