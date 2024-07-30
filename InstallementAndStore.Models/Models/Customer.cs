using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallementAndStore.Models.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; } = new Guid();
        public string CustomerName{ get; set; }
        public string CustomerAddress{ get; set; }
        public string CustomerPhone{ get; set; }
        public string SponserName{ get; set; }
        public string SponserAddress{ get; set; }
        public string SponserPhone{ get; set; }
        public bool  IsActive{ get; set; }
        public DateTime CreatedDate{ get; set; }



    }
}
