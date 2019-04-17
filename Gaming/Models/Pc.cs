namespace Gaming.Models
{
    public class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public decimal PriceDiscount { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl{ get; set; }
        public bool IsPcOfTheWeek { get; set; }
    }
}
