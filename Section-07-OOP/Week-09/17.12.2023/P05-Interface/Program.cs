namespace P05_Interface
{
    public interface IPerson
    {
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public void Info();
    }
    public interface IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public interface IEmployee
    {
        public string SubDepartment { get; set; }
    }

    public class Admin : IPerson, IPersonal
    {
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Info()
        {
            throw new NotImplementedException();
        }
    }
    public class Guest : IPersonal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Employee : IPerson, IPersonal, IEmployee
    {
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SubDepartment { get; set; }

        public void Info()
        {
            Console.WriteLine($"{City} - {Department}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.City = "İstanbul";
            admin.Info();


            Console.ReadLine();

        /*
        -Bir class sadece bir classtan miras alabilir
        -Abstrac class ya da interface classtan yeni bir nesne üretilemez ( new yapılamaz)
        -Bir abstrac class içinde hem soyut, hem somut memberlar bulunabilir.
        -Dolayısıyla bir abstrac classa hem soyut hem de somut memberlarımız varsa ihtiyaç duyarız. Eğer sadece soyut yapılara ihtiyacımız varsa Interface kullanırız. Yani bir Interface içerisindeki tüm memberlar soyuttur.
        -Eğer bir class hem interface hem de classtan miras alacak ise öncelikle class ismi yazılmalıdır. Sonrasında birden fazla interface yazılarak implemente edilebilir.
 
         */


        }
    }
}