using System;

class Program
{
    static void Main()
    {
        int tanlov;

        do
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("       AXBOROT XAVFSIZLIGI");
            Console.WriteLine("          SHAXSIY PORTFOLIO");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Men haqimda");
            Console.WriteLine("2. Yo'nalishim haqida");
            Console.WriteLine("3. Bilim va ko'nikmalarim");
            Console.WriteLine("4. Axborot xavfsizligi loyihalari");
            Console.WriteLine("5. Mashhur kiberxavfsizlik olimlari");
            Console.WriteLine("6. Kelajakdagi maqsadlarim");
            Console.WriteLine("0. Chiqish");
            Console.WriteLine("======================================");

            Console.Write("Tanlovingiz: ");

            if (!int.TryParse(Console.ReadLine(), out tanlov))
            {
                Console.WriteLine("Raqam kiriting!");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            switch (tanlov)
            {
                case 1:
                    Console.WriteLine("MEN HAQIMDA");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Ism: Sunnatillo");
                    Console.WriteLine("Familiya: Abdumalikov");
                    Console.WriteLine("Yo'nalish: Axborot xavfsizligi");
                    Console.WriteLine("Dasturlash tili: C#");
                    break;

                case 2:
                    Console.WriteLine("AXBOROT XAVFSIZLIGI");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Axborotlarni himoya qilish sohasi.");
                    Console.WriteLine("Ma'lumotlarning maxfiyligini");
                    Console.WriteLine("ta'minlash va ularni himoyalash.");
                    Console.WriteLine("Kiberhujumlarning oldini olish.");
                    break;

                case 3:
                    Console.WriteLine("BILIM VA KO'NIKMALARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. C# dasturlash tili");
                    Console.WriteLine("2. Kriptografiya asoslari");
                    Console.WriteLine("3. Parol xavfsizligi");
                    Console.WriteLine("4. Algoritmlar");
                    Console.WriteLine("5. Axborotni himoyalash");
                    Console.WriteLine("6. Kompyuter tarmoqlari");
                    break;

                case 4:
                    Console.WriteLine("MENING LOYIHALARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Parol tekshiruvchi");
                    Console.WriteLine("2. Modular kalkulyator");
                    Console.WriteLine("3. Faktorial hisoblash");
                    Console.WriteLine("4. Shaxsiy portfolio");
                    break;

                case 5:
                    Console.WriteLine("MASHHUR OLIMLAR");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Klod Shennon");
                    Console.WriteLine("2. Uitfild Diffi");
                    Console.WriteLine("3. Martin Hellman");
                    Console.WriteLine("4. Ronald Rivest");
                    Console.WriteLine("5. Adi Shamir");
                    Console.WriteLine("6. Leonard Adleman");
                    Console.WriteLine("7. Shafi Goldwasser");
                    Console.WriteLine("8. Radia Perlman");
                    Console.WriteLine("9. Bryus Shneyer");
                    break;

                case 6:
                    Console.WriteLine("KELAJAKDAGI MAQSADLARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Kiberxavfsizlikni chuqur o'rganish");
                    Console.WriteLine("2. Kuchli dasturchi bo'lish");
                    Console.WriteLine("3. Kriptografiyani o'rganish");
                    Console.WriteLine("4. Tizimlarni himoyalash");
                    Console.WriteLine("5. Professional mutaxassis bo'lish");
                    break;

                case 0:
                    Console.WriteLine("Portfolio yakunlandi!");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

            if (tanlov != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Menyuga qaytish uchun Enter bosing...");
                Console.ReadLine();
            }

        } while (tanlov != 0);
    }
}

using System;

class Program
{
    static void Main()
    {
        int tanlov;

        do
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("       AXBOROT XAVFSIZLIGI");
            Console.WriteLine("          SHAXSIY PORTFOLIO");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Men haqimda");
            Console.WriteLine("2. Yo'nalishim haqida");
            Console.WriteLine("3. Bilim va ko'nikmalarim");
            Console.WriteLine("4. Axborot xavfsizligi loyihalari");
            Console.WriteLine("5. Mashhur kiberxavfsizlik olimlari");
            Console.WriteLine("6. Kelajakdagi maqsadlarim");
            Console.WriteLine("0. Chiqish");
            Console.WriteLine("======================================");

            Console.Write("Tanlovingiz: ");

            if (!int.TryParse(Console.ReadLine(), out tanlov))
            {
                Console.WriteLine("Raqam kiriting!");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            switch (tanlov)
            {
                case 1:
                    Console.WriteLine("MEN HAQIMDA");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Ism: Sunnatillo");
                    Console.WriteLine("Familiya: Abdumalikov");
                    Console.WriteLine("Yo'nalish: Axborot xavfsizligi");
                    Console.WriteLine("Dasturlash tili: C#");
                    break;

                case 2:
                    Console.WriteLine("AXBOROT XAVFSIZLIGI");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Axborotlarni himoya qilish sohasi.");
                    Console.WriteLine("Ma'lumotlarning maxfiyligini");
                    Console.WriteLine("ta'minlash va ularni himoyalash.");
                    Console.WriteLine("Kiberhujumlarning oldini olish.");
                    break;

                case 3:
                    Console.WriteLine("BILIM VA KO'NIKMALARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. C# dasturlash tili");
                    Console.WriteLine("2. Kriptografiya asoslari");
                    Console.WriteLine("3. Parol xavfsizligi");
                    Console.WriteLine("4. Algoritmlar");
                    Console.WriteLine("5. Axborotni himoyalash");
                    Console.WriteLine("6. Kompyuter tarmoqlari");
                    break;

                case 4:
                    Console.WriteLine("MENING LOYIHALARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Parol tekshiruvchi");
                    Console.WriteLine("2. Modular kalkulyator");
                    Console.WriteLine("3. Faktorial hisoblash");
                    Console.WriteLine("4. Shaxsiy portfolio");
                    break;

                case 5:
                    Console.WriteLine("MASHHUR OLIMLAR");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Klod Shennon");
                    Console.WriteLine("2. Uitfild Diffi");
                    Console.WriteLine("3. Martin Hellman");
                    Console.WriteLine("4. Ronald Rivest");
                    Console.WriteLine("5. Adi Shamir");
                    Console.WriteLine("6. Leonard Adleman");
                    Console.WriteLine("7. Shafi Goldwasser");
                    Console.WriteLine("8. Radia Perlman");
                    Console.WriteLine("9. Bryus Shneyer");
                    break;

                case 6:
                    Console.WriteLine("KELAJAKDAGI MAQSADLARIM");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Kiberxavfsizlikni chuqur o'rganish");
                    Console.WriteLine("2. Kuchli dasturchi bo'lish");
                    Console.WriteLine("3. Kriptografiyani o'rganish");
                    Console.WriteLine("4. Tizimlarni himoyalash");
                    Console.WriteLine("5. Professional mutaxassis bo'lish");
                    break;

                case 0:
                    Console.WriteLine("Portfolio yakunlandi!");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov!");
                    break;
            }

            if (tanlov != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Menyuga qaytish uchun Enter bosing...");
                Console.ReadLine();
            }

        } while (tanlov != 0);
    }
}
