namespace P13_Methods
{
    internal class Program
    {
        static void SelamVer()
        {
            Console.WriteLine("Günaydın");
        }
        static int KacKelime(string metin)
        {
           string[] kelimeler =  metin.Split(' ');
            return kelimeler.Length;
        }
        static int KelimeAdedi(string metin, string aranacakMetin, bool buyukKucuk) 
        {
            if (!buyukKucuk)
            {
                metin = metin.ToLower();
                aranacakMetin = aranacakMetin.ToLower();
            }
            string[] kelimeler = metin.Split(' ');
            int adet = 0;
            foreach (var kelime in kelimeler)
            {
                if (kelime == aranacakMetin) adet++;
            }
            return adet;
        }
        static int[] SayiUret(int adet, int min, int max)
        {
            Random random = new Random();
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = random.Next(min, max);
            }
            return sayilar;
        }
        static int SesliHarfAdedi(string metin)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            int sesliHarfAdedi = 0;
            metin = metin.ToLower();
            for (int i = 0;i < metin.Length;i++)
            {
                if (sesliHarfler.Contains(metin[i])) sesliHarfAdedi++;
            }
            return sesliHarfAdedi;
        }
        static int[] SesliSessizHarfAdedi(string metin)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            char[] sessizHarfler = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'x', 'z' };
            int sesliHarfAdedi = 0;
            int sessizHarfAdedi = 0;
            metin = metin.ToLower();
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliHarfler.Contains(metin[i]))
                {
                    sesliHarfAdedi++;
                }
                else if (sessizHarfler.Contains(metin[i]))
                {
                    sessizHarfAdedi++;
                }
            }
                int[] sesliSessizHarfAdedi = {sesliHarfAdedi, sessizHarfAdedi };
                return sesliSessizHarfAdedi;

        }
        // İçinde türkçe karakter barındırmadan tüm küçük harfleri 0 ile 9 arasındaki rakamları, nokta(.), virgül(,), artı(+), eksi(-) işaretlerini barındırabilen, toplam uzunluğu 6 karakter olacak şekilde rastgele bir şifre üreten methodu yazınız.
        static string RandomPassword()
        {
            string karakterler = "abcdefghijklmnoprstuvyzx0123456789.,+-";
            Random random = new Random();
            string password = "";
            for (int i = 0;i < 6;i++)
            {
                password += karakterler[random.Next(0, karakterler.Length)];
            }
            return password;
        }

        // Şifre Üretme
        // 1-) Mutlaka harf ile başlamalı
        // 2-) içinde bir rakam olmalı
        // 3-)içinde bir adet özel karakter olmalı(+-.,)
        // 4-)kalan karakterler harf olmalı
        // 5-)toplam şifre uzunluğu 6 karakter olmalı
        // 6-)büyük harf kullanılmamalı.
        static string RandomPassword2()
        {
            string harfler = "abcdefghijklmnoprstuvyzx";
            string rakamlar = "0123456789";
            string ozel = "+-.,";
            Random random =new Random();
            string password = "";
            password += harfler[random.Next(0, harfler.Length)];
            password += rakamlar[random.Next(0, rakamlar.Length)];
            password += ozel[random.Next(0, ozel.Length)];
            for (int i = 0; i < 3; i++)
            {
                password += harfler[random.Next(0, harfler.Length)];
            }
            return password;
        }

        static void Main(string[] args)
        {
            //SelamVer();
            //Console.WriteLine("Bir cümle giriniz");
            //string cumle = Console.ReadLine();
            //int kelimeSayisi = KacKelime(cumle);
            //Console.WriteLine($"{cumle} cümlesindeki kelime sayisi: {kelimeSayisi}");

            //int adet = KelimeAdedi("Bugün çok güzel. Çok mutluyum. Çok iyiyim ", "çok", true);
            //Console.WriteLine(adet);
            //int sayi = 5;
            //int[] dizi = new int[sayi];

            //int[] sayilar = SayiUret(10, 1, 100);
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //Console.WriteLine(SesliHarfAdedi("Gel"));

            //int[] sonuc = SesliSessizHarfAdedi("türk");
            //Console.WriteLine($"Sesli harf adedi: {sonuc[0]}\nSessiz harf adedi: {sonuc[1]}");
            //Console.WriteLine(RandomPassword());
            Console.WriteLine(RandomPassword2());
            Console.ReadLine();
        }
    }
}