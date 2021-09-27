using FedexAPI.Models;
using FedexAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FedexAPI.Controllers
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
        [Route("ShippingQuote")]
        public IActionResult ShippingQuote(QuoteModel quoteModel)
        {
            var rate = _rateService.CalculateRate(quoteModel);
            return Ok(rate);
        }
    }
}