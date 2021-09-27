using FedexAPI.Models;

namespace FedexAPI.Services
{
    public class RateService : IRateService
    {
        public RateModel CalculateRate(QuoteModel quoteModel)
        {
            var rateModel = new RateModel
            {
                Amount = 30 + (5 * quoteModel.Cartons.Count)
            };
            return rateModel;
        }
    }
}