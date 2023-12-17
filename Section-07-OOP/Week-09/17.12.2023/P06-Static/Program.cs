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
            Random random = new Random();
            Deneme.Sayi = 45;

        }
    }
}