using Microsoft.AspNetCore.Mvc;
using PurolatorAPI.Models;

namespace PurolatorAPI.Controllers
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
                Total = 12
            };
        }
    }
    
}