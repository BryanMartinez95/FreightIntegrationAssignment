using PurolatorAPI.Models;

namespace PurolatorAPI.Services
{
    public class RateService : IRateService
    {
        public RateModel CalculateRate(QuoteModel quoteModel)
        {
            var rateModel = new RateModel
            {
                Total = 5 + (10 * quoteModel.PackageDimensions.Count)
            };
            return rateModel;
        }
    }
}