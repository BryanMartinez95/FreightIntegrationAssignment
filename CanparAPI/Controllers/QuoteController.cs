using CanparAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CanparAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        [HttpPost]
        [Consumes("application/xml")]
        [Produces("application/xml")]
        public IActionResult Quote(QuoteModel quoteModel)
        {
            var model = new RateModel
            {
                Quote = 10,
            };
            return Ok(model);
        }
    }
}