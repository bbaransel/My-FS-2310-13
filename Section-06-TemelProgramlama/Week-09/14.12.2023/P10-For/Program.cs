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
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] newNumbers = new int[5];
            int index = 0;
            foreach (var number in numbers)
            {
                newNumbers[index] = number+2;
                index++;
            }
            #endregion
            Console.ReadLine(); // En soldan gri yuvarlak ya da F9 ile breakpoint koyabiliyoruz.
        }
    }
}