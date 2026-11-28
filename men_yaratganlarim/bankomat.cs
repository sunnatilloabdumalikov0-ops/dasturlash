
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double balans = 5000000;
        string pin = "1234";
        int urinish = 0;
        bool kirish = false;

        List<string> tarix = new List<string>();

        Console.WriteLine("================================");
        Console.WriteLine("       BANKOMAT TIZIMI");
        Console.WriteLine("================================");

        // PIN-kodni tekshirish
        while (urinish < 3)
        {
            Console.Write("PIN-kodni kiriting: ");
            string kod = Console.ReadLine();

            if (kod == pin)
            {
                kirish = true;
                Console.WriteLine("Xush kelibsiz!");
                break;
            }
            else
            {
                urinish++;
                Console.WriteLine("PIN-kod noto'g'ri!");
                Console.WriteLine("Qolgan urinish: " + (3 - urinish));
            }
        }

        if (!kirish)
        {
            Console.WriteLine("Karta bloklandi!");
            return;
        }

        int tanlov;

        do
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("           ASOSIY MENYU");
            Console.WriteLine("================================");
            Console.WriteLine("1. Balansni tekshirish");
            Console.WriteLine("2. Pul yechish");
            Console.WriteLine("3. Hisobni to'ldirish");
            Console.WriteLine("4. Operatsiyalar tarixi");
            Console.WriteLine("5. PIN-kodni o'zgartirish");
            Console.WriteLine("0. Chiqish");
            Console.WriteLine("================================");

            Console.Write("Tanlovingiz: ");

            if (!int.TryParse(Console.ReadLine(), out tanlov))
            {
                Console.WriteLine("Noto'g'ri tanlov!");
                continue;
            }

            switch (tanlov)
            {
                case 1:
                    Console.WriteLine("Joriy balans: " + balans + " so'm");
                    break;

                case 2:
                    Console.Write("Yechiladigan summani kiriting: ");

                    if (!double.TryParse(Console.ReadLine(), out double yechish))
                    {
                        Console.WriteLine("Noto'g'ri summa!");
                        break;
                    }

                    if (yechish <= 0)
                    {
                        Console.WriteLine("Summa musbat bo'lishi kerak!");
                    }
                    else if (yechish > balans)
                    {
                        Console.WriteLine("Mablag' yetarli emas!");
                    }
                    else
                    {
                        balans -= yechish;
                        Console.WriteLine("Pul muvaffaqiyatli yechildi!");
                        Console.WriteLine("Qolgan balans: " + balans + " so'm");
                        tarix.Add("Pul yechildi: " + yechish + " so'm");
                    }
                    break;

                case 3:
                    Console.Write("Qo'shiladigan summani kiriting: ");

                    if (!double.TryParse(Console.ReadLine(), out double qoshish))
                    {
                        Console.WriteLine("Noto'g'ri summa!");
                        break;
                    }

                    if (qoshish <= 0)
                    {
                        Console.WriteLine("Summa musbat bo'lishi kerak!");
                    }
                    else
                    {
                        balans += qoshish;
                        Console.WriteLine("Hisob to'ldirildi!");
                        Console.WriteLine("Yangi balans: " + balans + " so'm");
                        tarix.Add("Hisob to'ldirildi: " + qoshish + " so'm");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nOPERATSIYALAR TARIXI:");

                    if (tarix.Count == 0)
                    {
                        Console.WriteLine("Hozircha operatsiyalar mavjud emas.");
                    }
                    else
                    {
                        foreach (string amal in tarix)
                        {
                            Console.WriteLine(amal);
                        }
                    }
                    break;

                case 5:
                    Console.Write("Eski PIN-kodni kiriting: ");
                    string eskiPin = Console.ReadLine();

                    if (eskiPin == pin)
                    {
                        Console.Write("Yangi PIN-kodni kiriting: ");
                        string yangiPin = Console.ReadLine();

                        if (yangiPin.Length == 4 &&
                            int.TryParse(yangiPin, out _))
                        {
                            pin = yangiPin;
                            Console.WriteLine("PIN-kod o'zgartirildi!");
                            tarix.Add("PIN-kod o'zgartirildi");
                        }
                        else
                        {
                            Console.WriteLine("PIN 4 ta raqamdan iborat bo'lishi kerak!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eski PIN-kod noto'g'ri!");
                    }
                    break;

                case 0:
                    Console.WriteLine("Kartangizni oling!");
                    Console.WriteLine("Xizmatimizdan foydalanganingiz uchun rahmat!");
                    break;

                default:
                    Console.WriteLine("Bunday bo'lim mavjud emas!");
                    break;
            }

        } while (tanlov != 0);
    }
}
