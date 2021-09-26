using CanparAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CanparAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        [HttpGet]
        [Consumes("application/xml")]
        public RateModel Quote()
        {
            return new RateModel
            {
                Quote = 10
            };
        }
    }

    public class QuoteResponse
    {
        public double Amount { get; set; }
    }
}