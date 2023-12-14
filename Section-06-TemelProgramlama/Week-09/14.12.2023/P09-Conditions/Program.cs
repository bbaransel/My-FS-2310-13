using System.Threading.Channels;

namespace P09_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF Intro

            //Console.Write("Yaş: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age>=18)
            //{
            //    Console.WriteLine("giriş yapabilirsiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("giremezsin");
            //}

            // Tek satırda

            //if (age >= 18) Console.WriteLine("girebilirsin");
            //else Console.WriteLine("giremezsin");

            #endregion
            #region IF-ElseIF
            //int age = 45;
            //if (age <= 18)
            //{
            //    Console.WriteLine("çocuk");
            //}
            //else if(age <=48)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşlı");
            //}

            #endregion
            #region TernaryIf
            int age = 10;
            //Console.WriteLine(age<=18 ? "çocuk" : "genç");
            string message = age <= 18 ? "çocuk" : "genç";
            Console.WriteLine(message);
            #endregion
            #region Switch-Case

            //int x = 25;
            //switch (x)
            //{
            //    case 5:
            //        Console.WriteLine("Bgün ayın 5i");
            //        break;
            //    case 10:
            //        Console.WriteLine("bugün ayın 10u");
            //        break;
            //    case 15:
            //        Console.WriteLine("bugün ayın 15i");
            //        break;
            //    case 20:
            //        Console.WriteLine("bugün ayın 20si");
            //        break;
            //    case 25:
            //        Console.WriteLine("bugün ayın 25i");
            //        break;
            //    case 30:
            //        Console.WriteLine("bugün ayın 30u");
            //        break;
            //    default:
            //        Console.WriteLine("söylenecek söz yok");

            //}

        #endregion
            #region Switch-Case2
            int x = 25;
            switch (x)
            {
                case 5:
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                    Console.WriteLine("Beşin katı");
                default:
                    Console.WriteLine("söylenecek söz yok");
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}