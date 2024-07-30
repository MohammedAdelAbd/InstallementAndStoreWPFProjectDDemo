using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Models.Models
{
    public class InvoiceItem
    {
        [Key]
        public Guid InvoiceId { get; set; } = new Guid();
        public decimal InvoiceAmount { get; set; }
        public decimal FirstPayment { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTime  CreatedDate { get; set; }
        public DateTime  ModifidedDate { get; set; }
        public bool isActive { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }



        [ForeignKey(nameof(CustomerId))]
        public Customer customer { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product product { get; set; }


    }
}
