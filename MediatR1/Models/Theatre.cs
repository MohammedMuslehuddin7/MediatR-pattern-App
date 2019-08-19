using System;
using System.Collections.Generic;

namespace MediatR1.Models
{
    public partial class Theatre
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime? MovieDate { get; set; }
        public int? AvailableTickets { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? MoviePrice { get; set; }
    }
}
