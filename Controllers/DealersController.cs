using System.Collections.Generic;
using CarDealer.Data;
using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{

    [Route("api/dealers")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        private readonly IDealerRepo _repository;

        public DealersController(IDealerRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockDealerRepo _repository = new MockDealerRepo();

        //GET api/dealers
        [HttpGet]
        public ActionResult <IEnumerable<Dealer>> GetAllDealers()
        {
            return Ok(_repository.GetAllDealers());
        }

        //GET api/dealers/{id}
        [HttpGet("{id}")]
        public ActionResult <IEnumerable<Dealer>> GetDealerById(int id)
        {
            return Ok(_repository.GetDealerById(id));
        }

    }
}