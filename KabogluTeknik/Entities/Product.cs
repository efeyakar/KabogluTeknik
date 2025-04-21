namespace KabogluTeknik.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TrendyolUrl { get; set; }
        public string HepsiburadaUrl { get; set; }
    }
}
