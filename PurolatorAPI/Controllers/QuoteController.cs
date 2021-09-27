using Microsoft.AspNetCore.Mvc;
using PurolatorAPI.Models;
using PurolatorAPI.Services;

namespace PurolatorAPI.Controllers
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
        [Route("TransportationCost")]
        public IActionResult TransportationCost(QuoteModel quoteModel)
        {
            var rate = _rateService.CalculateRate(quoteModel);
            
            return Ok(rate);
        }
    }
    
}