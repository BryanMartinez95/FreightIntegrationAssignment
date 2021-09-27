using PurolatorAPI.Models;

namespace PurolatorAPI.Services
{
    public interface IRateService
    {
        RateModel CalculateRate(QuoteModel quoteModel);
    }
}