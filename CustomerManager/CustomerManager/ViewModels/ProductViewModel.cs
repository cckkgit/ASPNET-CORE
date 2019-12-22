using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        [Display(Name = "Ten")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double TotalPrice { get; set; }
    }
}
