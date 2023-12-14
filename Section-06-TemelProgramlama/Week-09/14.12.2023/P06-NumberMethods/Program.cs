namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En küçük: {Math.Min(number1,number2)}");
            //Console.WriteLine($"En büyük: {Math.Max(number1,number2)}");
            //int sayi = 4;
            //int us = 2;
            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            //Console.WriteLine(sonuc);
            //Console.WriteLine("Bir sayı giriniz");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı giriniz");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1+number2);
            //Console.WriteLine($"Girdiğiniz sayı:\n\t{number1}");


            //Console.WriteLine("Lütfen taban değerini giriniz");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen üs değerini giriniz");
            //int us = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{taban} sayısının {us}. kuvveti :\n\t{Math.Pow(taban, us)} ");


            double sayi = 5.49892;
            Console.WriteLine(sayi);
            Console.WriteLine($"Ceiling {Math.Ceiling(sayi)}");
            Console.WriteLine($"Floor {Math.Floor(sayi)}");
            Console.WriteLine($"Round {Math.Round(sayi)}");
            Console.WriteLine($"Round2 {Math.Round(sayi,3)}");



            Console.ReadLine();
            }
    }
}