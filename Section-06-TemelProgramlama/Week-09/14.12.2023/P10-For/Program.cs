namespace P10_For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            #endregion
            #region ForEach
            //string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };

            //foreach (var x in names)
            //{
            //    Console.WriteLine(x);
            //};
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] newNumbers = new int[5];
            //int index = 0;
            //foreach (var number in numbers)
            //{
            //    newNumbers[index] = number+2;
            //    index++;

            // klavyeden girilicek bir sayıya kadar olan sayıların içinden kaç tanesinin çift kaç tanesinin tek sayı olduğunu bulup consola yazıdran kodu yazalım.
            
            Console.Write("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int ciftSayiAdedi = 0;
            int ucunKatiSayiAdedi = 0;
            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 0) ciftSayiAdedi++;
                if (i % 3 == 0) ucunKatiSayiAdedi++;
            }
            Console.Clear();
            Console.WriteLine("Sonuç");
            Console.WriteLine("-----");
            Console.WriteLine($"0-{sayi} arasındaki çift sayiların adedi: {ciftSayiAdedi}\n0-{sayi} arasındaki 3ün katı sayıların adedi: {ucunKatiSayiAdedi}");







            #endregion
            Console.ReadLine(); // En soldan gri yuvarlak ya da F9 ile breakpoint koyabiliyoruz.
        }
    }
}