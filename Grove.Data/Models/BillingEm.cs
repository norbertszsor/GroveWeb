﻿using Grove.Data.Abstraction;

namespace Grove.Data.Models
{ 
    public class BillingEm : Entity
    {
        public DateTime Date { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal GrandTotal { get; set; }

        public required Guid CustomerId { get; set; }

        public virtual required CustomerEm Customer { get; set; }

        public virtual ICollection<BillingItemEm>? Items { get; set; }
    }
}
