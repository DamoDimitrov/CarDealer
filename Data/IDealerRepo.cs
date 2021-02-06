using System.Collections.Generic;
using CarDealer.Models;

namespace CarDealer.Data
{
    public interface IDealerRepo
    {
        IEnumerable<Dealer> GetAllDealers();
        Dealer GetDealerById(int id);
    }
}