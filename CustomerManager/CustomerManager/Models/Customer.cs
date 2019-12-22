using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models
{
    public class Customer 
    {
        [Required]
        [StringLength(20)]
            public string Name { get; set; }

        [Required]
        [Range(18,40)]
            public int Age { get; set; }
    }
}
