namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //double result = Convert.ToDouble(sayi1/sayi2);
            //Console.WriteLine(result);
            //Console.ReadLine();
            #region Intro
            /*
            Uygulamalarımız çalıştıkları esnada bir takım hatalardan dolayı durdurulabilir.
             - Bu tür hatalara Run Time Errors ( Çalışma Zamanı Hataları ) denir.
            Run Time Errors'ı kontrol altına almak için Try-Catch-Finally yapısını kullanacağız.

            try
            {
            Çalışmasını beklediğimiz kodları buraya yazacağız.Yani hata verme olasılığı olan kodlar.Dolayısıyla buraya yazdığımız kodları şu şekilde düşünebiliriz.Bu kodları çalıştırmayı DENE! Çlaışıyorsa hiçbir sorun olmadan devam eder, yani cacth scopeunu atlar, çalıştırmaz. Çalışmıyorsa, hata varsa catch scope'una geçer.
            }
            catch
            {
            Eğer try scope'undaki kodda bir hata meydana gelirse bu bölümdeki kodlar çalışır.
            }
            finally
            {
            try ya da catch scopelarından hangisi çalışmış olursa olsun her halükarda bu kısımda yazılan kodlar çalıştırılır.
            }
*/


            #endregion
            #region Sample01
            //Console.Write("Lütfen karesi alınacak sayıyı giriniz.");
            //try
            //{
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
            //    Console.WriteLine(sonuc);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            #endregion
            #region Sample02
            try
            {
                Console.Write("Bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.Write("Bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen} / {bolen} = {sonuc} ");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Bölen 0 olmamalı");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir şey oldu");
            }



            Console.ReadLine();


            #endregion
        }
    }
}