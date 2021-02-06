namespace CarDealer.Models
{
    public class Deal
    {
        public int id { get; set; }
        public int DealerId { get; set; }
        public int CustomerId { get; set; }

        public Vehicle car { get; set; }
    }
}