namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            // C# da veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özeillikle sayılar ve sayı olmayanlar olmak üzere incelemek iyi olacaktır.
            // TAM SAYILAR
            byte sayi1 = 255;
            sbyte sayi2 = -15;
            Console.WriteLine(sayi1 + "sayısının alabileceği minimum değer: " + byte.MinValue);
            Console.WriteLine(sayi1 + "sayısının alabileceği maximum değer: " + byte.MaxValue);
            Console.WriteLine(sayi1 + "sayısının bellekte kapladığı değer: " + sizeof(byte) + " byte");
            Console.WriteLine(sayi2 + " - " + sizeof(long) + " byte");

            #endregion
            Console.ReadLine();
        }
    }
}