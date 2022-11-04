﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItemShop.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product Name is required", AllowEmptyStrings = false)]
        [MinLength(6, ErrorMessage = "Product Name min is 6 characters")]
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required", AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Product Name min is 5 characters")]
        [MaxLength(11, ErrorMessage = "Product Name max is 11 characters")]
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}