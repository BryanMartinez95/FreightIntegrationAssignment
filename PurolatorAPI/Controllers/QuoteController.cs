using Microsoft.AspNetCore.Mvc;
using PurolatorAPI.Models;

namespace PurolatorAPI.Controllers
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
                Total = 12
            };
        }
    }
    
}