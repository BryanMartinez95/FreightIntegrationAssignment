using FedexAPI.Models;

namespace FedexAPI.Services
{
    public interface IRateService
    {
        RateModel CalculateRate(QuoteModel quoteModel);
    }
}