using System.Collections.Generic;

namespace PurolatorAPI.Models
{
    public class QuoteModel
    {
        public string ContactAddress { get; set; }
        public string WarehouseAddress { get; set; }
        public List<string> PackageDimensions { get; set; }
    }
}