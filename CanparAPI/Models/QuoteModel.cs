using System.Collections.Generic;

namespace CanparAPI.Models
{
    public class QuoteModel
    {
        public QuoteModel()
        {
            
        }
        public string Source { get; set; }
        public string Destination { get; set; }
        public List<string> Packages { get; set; }
    }
}