namespace MiniShop.Mvc.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
