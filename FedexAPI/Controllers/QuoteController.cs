using FedexAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FedexAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        [HttpPost]
        public RateModel Quote(QuoteModel quoteModel)
        {
            return new RateModel
            {
                Amount = 33
            };
        }
    }
}