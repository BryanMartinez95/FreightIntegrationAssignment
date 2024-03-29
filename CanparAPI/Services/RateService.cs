﻿using CanparAPI.Models;

namespace CanparAPI.Services
{
    public class RateService : IRateService
    {
        public RateModel CalculateRate(QuoteModel quoteModel)
        {
            var rateModel = new RateModel
            {
                Quote = 10 * quoteModel.Packages.Count
            };
            return rateModel;
            
        }
    }
}