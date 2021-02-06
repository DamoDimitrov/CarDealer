using System.Collections.Generic;
using CarDealer.Models;

namespace CarDealer.Data
{
    public class MockDealerRepo : IDealerRepo
    {
        public IEnumerable<Dealer> GetAllDealers()
        {
            var dealers = new List<Dealer>
            {
                new Dealer{id=0, FirstName="Peter", LastName="Pan", Company="Don", PhoneNumber=156723123, Deals={}},
                new Dealer{id=1, FirstName="Pete", LastName="Peterson", Company="Vast&Curios", PhoneNumber=123123123, Deals={}},
                new Dealer{id=2, FirstName="Mark", LastName="Varn", Company="Vast&Curios", PhoneNumber=98723123, Deals={}}
            };
            return dealers;
        }

        public Dealer GetDealerById(int id)
        {
            return new Dealer{id=0, FirstName="Pete", LastName="Pavlovski", Company="Vast&Curios", PhoneNumber=123123123, Deals={}};
        }
    }
}