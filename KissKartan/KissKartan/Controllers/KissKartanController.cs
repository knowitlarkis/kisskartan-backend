using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using KissKartan.API.Models;

namespace KissKartan.API.Controllers
{
    public class KissKartanController : Controller
    {
        public ToiletService toiletService = new ToiletService();
        public IActionResult Index()
        {
            return View();
        }

        [Route("getToilets")]
        [HttpGet]
        public Toilet [] GetToilets()
        {
            return toiletService.GetAll();
        }
    }
}
