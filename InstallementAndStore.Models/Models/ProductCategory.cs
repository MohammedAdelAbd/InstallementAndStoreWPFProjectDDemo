﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Models.Models
{
    //one
    public class ProductCategory
    {
        [Key]
        public Guid ProductCatId { get; set; } = new Guid();
        public string ProductCatName { get; set; }
    }
}
