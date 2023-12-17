namespace P04_Inheritance
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public abstract void Intro();
        public void Greating()
        {
            Console.WriteLine("Greatings Traveler!");
        }
    }
    public class Category : Base
    {
        public string Desc { get; set; }
        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
    public class Produc : Base
    {
        public override void Intro()
        {
            throw new NotImplementedException();
        }
        public string Properties { get; set; }
        public double Price { get; set; }
    }





    internal class Abstraction
    {

    }
}
