using FedexAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FedexAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        [HttpGet]
        public RateModel Quote()
        {
            return new RateModel
            {
                Amount = 33
            };
        }
    }
}