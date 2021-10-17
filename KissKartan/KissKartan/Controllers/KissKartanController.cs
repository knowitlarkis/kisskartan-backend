using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using KissKartan.API.Models;

namespace KissKartan.API.Controllers
{
    public class KissKartanController : Controller
    {
        public ToiletService toiletService = new ToiletService();
        public RatingService ratingService = new RatingService();

        public IActionResult Index()
        {
            return View();
        }

        [Route("toilets")]
        [HttpGet]
        public List<Toilet> Toilets()
        {
            return toiletService.GetAll();
        }

        [Route("toilets/{id}")]
        [HttpGet]
        public Toilet Toilets(int id)
        {
            return toiletService.Get(id);
        }
        
        [Route("toilets/ratings/{toiletId}")]
        [HttpGet]
        public double Rating(int toiletId)
        {
            return ratingService.GetAverage(toiletId);
        }
        
        [Route("toilets/ratings")]
        [HttpGet]
        public List<Rating> Rating()
        {
            return ratingService.GetAll();
        }
    
    }
}
