using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates.Domain.Entities
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public string Currency { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Mid { get; set; }
        public DateTime Date { get; set; }
    }
}
