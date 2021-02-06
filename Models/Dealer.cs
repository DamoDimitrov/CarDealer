using System.Collections.Generic;

namespace CarDealer.Models
{
    public class Dealer 
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int PhoneNumber { get; set; }
        public IEnumerable<Deal> Deals { get; set; }
    }
}