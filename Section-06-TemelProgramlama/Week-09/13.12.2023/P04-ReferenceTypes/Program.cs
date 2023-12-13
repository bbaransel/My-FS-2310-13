namespace P04_ReferenceTypes
{
    class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference Types
            //int number1;
            //Console.WriteLine(number1);


            Random random = new Random();
            int sayi1 = random.Next();
            Console.WriteLine(sayi1);

            Product urun1 = new Product();


            #endregion



            Console.ReadLine();


        }
    }
}