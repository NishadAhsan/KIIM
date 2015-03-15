using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAnnotationsExtensions;

namespace KIIM.Models
{
    public class Product
    {
        public int productId { get; set; }

        [Required]
        [Display(Name = "Name ")]
        public string productName { get; set; }
        
        [Required]
        [RegularExpression(@"[0-9]{6,10}", ErrorMessage = "Product No. must be between 6-10 digits.")]
        [Display(Name = "Product No. #")]
        public string productNo { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Price ")]
        public decimal productPrice { get; set; }

    }
}