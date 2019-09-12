﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class WeekCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(250, ErrorMessage = "Length can't be more than 250")]
        public string Image { get; set; }
    }
}
