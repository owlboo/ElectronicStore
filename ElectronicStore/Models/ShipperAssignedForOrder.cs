using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class ShipperAssignedForOrder
    {
        public int Id { get; set; }
        [Display(Name = "Order")]
        public long OrderId { get; set; }
        [ForeignKey("OrderId")]
        public OrderBills Orders { get; set; }

        [Display(Name ="Shipper")]
        public string ShipperId { get; set; }
        [ForeignKey("ShipperId")]
        public ApplicationUsers Shippers { get; set; }
    }
}
