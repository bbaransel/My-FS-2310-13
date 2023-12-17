namespace P03_Constructor
{
    public class Student
    {
        public Student()
        {
            
        }
        public Student(int id, string name, bool gender, int age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }
        public Student(string name)
        {
            Name = name;
            Age = 18;
            Console.WriteLine("Bir student nesnesi olşturuldu.");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public void SelamVer() 
        {
            Console.WriteLine($"Merhaba! Ben {Name} {Age} yaşındayım.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Melek";
            //student.Gender = true;
            //student.Age = 22;
            //student.SelamVer();

            //Student student2 = new Student
            //{
            //    Id = 2,
            //    Name = "Çağdaş",
            //    Age = 28,
            //    Gender = false
            //};
            //student2.SelamVer();

            //Student student3 = new Student
            //{
            //    Id = 3,
            //    Gender = true
            //};
            //student3.SelamVer();

            //Student student4 = new Student("Ece");
            //student4.Gender = true;
            //student4.SelamVer();

            Student student5 = new Student(5,"Baransel", false, 26);
            student5.SelamVer();


            Console.ReadLine();
        }
    }
}