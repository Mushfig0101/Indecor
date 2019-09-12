using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int DiscountProduct { get; set; }

        public DateTime TimeDiscount { get; set; }
        public virtual ICollection<Product> ProductS { get; set; }


    }
}
