using CanparAPI.Models;
using CanparAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CanparAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        private readonly IRateService _rateService;
        public QuoteController(IRateService rateService)
        {
            _rateService = rateService;
        }
        
        [HttpPost]
        [Consumes("application/xml")]
        [Produces("application/xml")]
        [Route("Quote")]
        public IActionResult Quote(QuoteModel quoteModel)
        {
            var rate = _rateService.CalculateRate(quoteModel);
            
            return Ok(rate);
        }
    }
}