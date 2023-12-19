using P06_Static.Helper;

namespace P06_Static
{

    public static class Deneme
    {
        public static int Sayi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alex?de?Souza";
            //HelperMethods editText = new HelperMethods();
            //Console.WriteLine(editText.EditText(firstName));
            Console.WriteLine(HelperMethods.EditText(firstName));



            Console.ReadLine();
        }
    }
}