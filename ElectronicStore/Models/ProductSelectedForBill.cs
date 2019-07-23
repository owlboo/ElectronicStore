using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class ProductSelectedForBill
    {
        public long Id { get; set; }
        [Display(Name ="Orders")]
        public long OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual OrderBills Orders { get; set; }

        [Display(Name ="Products")]
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }
        public int ProductQuantity { get; set; }
    }
}
