using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class Product
    {

        public int Id { get; set; } 

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(5000, ErrorMessage = "Length can't be more than 5000")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(255, ErrorMessage = "Length can't be more than 255")]
        public string Image  { get; set; }

        //[Required(ErrorMessage = "Required")]
        public bool NewProduct { get; set; }

        //[Required(ErrorMessage = "Required")]
        public int MostView { get; set; }

        //[Required(ErrorMessage = "Required")]
        public int SellerCount { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }


    }
}
