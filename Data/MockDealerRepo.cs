using System.Collections.Generic;
using CarDealer.Models;

namespace CarDealer.Data
{
    public class MockDealerRepo : IDealerRepo
    {
        public IEnumerable<Dealer> GetAllDealers()
        {
            throw new System.NotImplementedException();
        }

        public Dealer GetDealerById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}