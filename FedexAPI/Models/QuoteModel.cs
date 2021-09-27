using System.Collections.Generic;

namespace FedexAPI.Models
{
    public class QuoteModel
    {
        public string Consignee { get; set; }
        public string Consignor { get; set; }
        public List<string> Cartons { get; set; }
    }
}