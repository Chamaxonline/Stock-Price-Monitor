using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Price
    {
        public int Id { get; set; }
        public int TickerId { get; set; }
        public int SourceId { get; set; }
        public DateTime Time { get; set; }
        public double PriceTag { get; set; }
        public bool Active { get; set; }
    }
}
