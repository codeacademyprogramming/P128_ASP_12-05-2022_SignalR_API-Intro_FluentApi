﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P224Allup.ViewModels.Order
{
    public class OrderVM
    {
        [StringLength(255), Required,EmailAddress]
        public string Email { get; set; }
        [StringLength(255), Required]
        public string FullName { get; set; }
        [StringLength(255), Required]
        public string Address { get; set; }
        [StringLength(255), Required]
        public string Country { get; set; }
        [StringLength(255), Required]
        public string City { get; set; }
        [StringLength(255), Required]
        public string State { get; set; }
        [StringLength(255), Required]
        public string ZipCode { get; set; }
    }
}
