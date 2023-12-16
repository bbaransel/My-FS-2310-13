using System.Collections;

namespace P12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //int[] ages = new int[3] { 5, 3, 6 };
            //int[] sizes = {5, 3, 6,7 ,8,12,213123,23};
            //Console.WriteLine(sizes[3]);

            //int[] sayilar = new int[50];
            //Random random = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = random.Next(1,101);
            //}
            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();
            //foreach (var sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftSayilar.Add(sayi);
            //    }
            //    else
            //    {
            //        tekSayilar.Add(sayi);
            //    }
            //}
            //    Console.WriteLine($"Çift sayi adedi: {ciftSayilar.Count}");
            //    Console.WriteLine($"Tek sayi adedi: {tekSayilar.Count}");

            Random random = new Random();
            int[] tekSayilar = new int[25];
            int[] ciftSayilar = new int[25];

            for (int i = 0; i < 25; i++)
            {
                int sayi = 0;
                do
                {
                    sayi = random.Next(0, 101);

                } while (sayi % 2 != 1);
                tekSayilar[i] = sayi;
                do
                {
                    sayi = random.Next(0, 101);

                } while (sayi % 2 != 0);
                ciftSayilar[i] = sayi;
            }
            Console.WriteLine("Tek sayilar:");
            foreach (var i in tekSayilar)
            {
                Console.Write($"{i}-");
            }
            Console.WriteLine("\nÇift sayilar:");
            foreach (var i in ciftSayilar)
            {
                Console.Write($"{i}-");
            }



            Console.ReadLine();
        }
    }
}