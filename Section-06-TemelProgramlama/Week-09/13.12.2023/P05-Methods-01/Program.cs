namespace P05_Methods_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Methods
            ////string name = "halil Umut MELER";
            ////int len = name.Length;
            ////Console.WriteLine("'" + name + "' metninin uzunluğu: " + len + " karakterdir");
            ////Console.WriteLine(name.ToLower());
            ////Console.WriteLine(name.ToUpper());
            //string m1 = "Bahçeşehir";
            //string m2 = "Üniversitesi";
            //int year = 1996;
            //Console.WriteLine(m1 +" "+ m2);
            //Console.WriteLine(String.Concat(m1, " ", m2));
            //Console.WriteLine(String.Concat(m1, " ", m2, " ", year, " yılında kurulmuştur.")); // içinde değişken tipi number cinsi olan bir değişken de kullanılabilir.
            //string result = $"{m1} {m2}";
            //string result2 = $"{m1} {m2} {year} yılında kurulmuştur.";

            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //string name = "Ece";
            //int age = 13;
            //string school = "Yeditepe İÖO";
            //string result = $"Ad: {name}\nYaş: {age}\nOkul: {school} ";
            //string result2 = $"{name}\t{age}\t{school}";
            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            //string courseName = "FullStack Web Developer Eğitimi";
            //string findIndex = "wEb";
            //bool result = courseName.ToLower().Contains(findIndex.ToLower());
            //Console.WriteLine(result);

            //string name = "Zeyno";
            //Console.WriteLine(name.IndexOf("ey"));
            //Console.WriteLine(name.StartsWith("z"));
            //Console.WriteLine(name.EndsWith("o"));


            //string school = "Yeditepe İlköğretim Mektebi";
            //string result = school.Replace("Mektebi", "Okulu");
            //Console.WriteLine(result);

            //string title = "C#'ta Metinsel İşlemler";
            //string result = title.ToLower().Replace(" ", "-").Replace("'","-");
            //string text = "Bugün hava çok güzeldi ama akşama doğru hava çok bozdu. Öyle bozdu öyle bozdu ki, daha da bozmaz dedik, daha da bozdu. Bozdukça bozdu.";
            //Console.WriteLine(text.Replace("a",""));
            //Console.WriteLine(result);
            string title = "Tesla, 2 milyon'dan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
            string result = title.ToLower().Replace(",", "").Replace("'", "").Replace(" ", "-").Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i").Replace("!","");
            Console.WriteLine(result);
            Console.WriteLine("selam");


            #endregion


            Console.ReadLine();
        }
    }
}