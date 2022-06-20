using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class SourceTicker
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int TickerId { get; set; }
    }
}
