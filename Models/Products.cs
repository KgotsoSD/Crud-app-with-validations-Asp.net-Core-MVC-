using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name="Product Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        public string Category { get; set; }
        [DataType(DataType.Text)]
        public string Color { get; set; }
        [Required]
        [Range(1,100,ErrorMessage="Please Enter a number between 1 and 100")]
        public decimal UnitPrice { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Please Enter a number between 1 and 30")]
        public int AvailableQuantity { get; set; }
    }
}
