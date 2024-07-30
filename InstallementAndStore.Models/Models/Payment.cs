using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Models.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; } = new Guid();
        public DateTime CreatedDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string Note { get; set; }
        public Guid CustomerId { get; set; }
        public Guid InvoiceId { get; set; }



        [ForeignKey(nameof(CustomerId))]
        public Customer customer { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        public InvoiceItem invoiceItems { get; set; }
    }
}
