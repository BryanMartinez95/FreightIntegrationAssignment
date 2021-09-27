using CanparAPI.Models;

namespace CanparAPI.Services
{
    public interface IRateService
    {
        RateModel CalculateRate(QuoteModel quoteModel);
    }
}