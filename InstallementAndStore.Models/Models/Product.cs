using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Models.Models
{
    //many
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; } = new Guid();
        public string ProductName { get; set; }
        public int ProductTotalQuantity { get; set; }

        public Guid ProductCatId { get; set; }
        [ForeignKey(nameof(ProductCatId))]
        public ProductCategory productCategory { get; set; } 
    }
}
