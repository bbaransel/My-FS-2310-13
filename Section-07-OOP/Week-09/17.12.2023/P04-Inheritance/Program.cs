namespace P04_Inheritance
{
    public class Alive
    {
        public string Category { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}");
        }
    }
    public class Student : Person
    {
        public int StudentNumber { get; set; }
    }
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public override void Intro()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Branch: {Branch}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student student1 = new Student();
            //Teacher teacher1 = new Teacher();
            //teacher1.FirstName = "Temel";
            //teacher1.LastName = "Suluk";
            //teacher1.Branch = "Fizik";

            //teacher1.Intro();

            Base nesne = new Base();
            
            Console.ReadLine();

        }
    }
}