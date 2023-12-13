namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            // C# da veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özeillikle sayılar ve sayı olmayanlar olmak üzere incelemek iyi olacaktır.
            // TAM SAYILAR
            //byte sayi1 = 255;
            //sbyte sayi2 = -15;
            //Console.WriteLine(sayi1 + "sayısının alabileceği minimum değer: " + byte.MinValue);
            //Console.WriteLine(sayi1 + "sayısının alabileceği maximum değer: " + byte.MaxValue);
            //Console.WriteLine(sayi1 + "sayısının bellekte kapladığı değer: " + sizeof(byte) + " byte");
            //byte sayi1 = 10;
            //ushort sayi2 = 20;
            //uint sayi3 = 30;
            //ulong sayi4 = 40;

            //sbyte sayi5 = -50;
            //short sayi6 = -60;
            //int sayi7 = -100;
            //long sayi8 = -110;





            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(sizeof(int) + "byte");





            #endregion

            #region ONDALIKLI SAYILAR
            //float sayi1 = 0.23f;
            //double sayi2 = 56;
            //decimal sayi3 = 76.1231m;
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(sizeof(float) + "byte");
            //Console.WriteLine(sayi1.GetType());
            //Console.WriteLine();
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(sizeof(double) + "byte");
            //Console.WriteLine(sayi2.GetType());

            //Console.WriteLine();
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(sizeof(decimal) + "byte");
            //Console.WriteLine(sayi3.GetType());



            #endregion

            #region METİN VE KARAKTERLER

            //char answer = 'A'; // Char kullanırken '' mutlaka tek tırnak kullanılır ve içinde sadece 1 karakter tanımlanır.
            //string name = "Ali Veli"; // Mutlaka çift tırnak kullanılır.

            //Console.WriteLine(answer + " tipi: " + answer.GetType() + "-" + char.MinValue + "-" + char.MaxValue);
            //Console.WriteLine(name[4]);



            #endregion

            #region MANTIKSAL
            //bool isActive = true;

            //Console.WriteLine(isActive);

            #endregion

            #region TARİH SAAT
            //DateTime birthday = new DateTime(1975, 7, 16);
            //Console.WriteLine(birthday);


            #endregion
            Console.ReadLine();
        }
    }
}