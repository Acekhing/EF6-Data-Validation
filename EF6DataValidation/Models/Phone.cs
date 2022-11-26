namespace EF6DataValidation.Models
{
    public class Phone
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public double Version { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Model { get; set; }
    }
}
