using System.Collections;

namespace P01_OOP_Intro
{
    public class Person
    {
        //Feild
        private int age;
        public int Age
        {
            get { return age - 10; }
            set { age = value;}
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value.ToLower(); }
        }

        private bool isStatus;
        public bool IsStatus
        {
            get
            {
                if (age >= 25) return true;
                return false;
            }
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Person ece = new Person();
            //Person ayse = new Person();
            //Person haydar = new Person();
            //ece.Age = 30;
            //ece.Name = "eCe";
            //ayse.Age = 20;
            //ayse.Name = "aySeNuR";
            //haydar.Age = 25;
            //haydar.Name = "hAydAr";

            //Console.WriteLine(ece.Name);
            //Console.WriteLine(ayse.Name);
            //Console.WriteLine(haydar.Name);

            //int yeniYas  = ece.Age*2;
            ////Console.WriteLine(yeniYas);

            //Console.WriteLine(ece.IsStatus);
            ArrayList products = new ArrayList();
            string answer = "E";
            do
            {
                Product product = new Product();
                Console.Write("Name: ");
                product.Name = Console.ReadLine();
                Console.Write("Description: ");
                product.Description = Console.ReadLine();
                Console.Write("Price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                products.Add(product);
                Console.WriteLine();
                Console.Write("Yeni ürün girmek istiyor musunuz?(E/H)");
                answer = Console.ReadLine().ToLower();

            } while (answer!="h");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}\t\tDescription: {product.Description}\t\tPrice: {product.Price}");
            }




            Console.ReadLine();

        }
    }
}