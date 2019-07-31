using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models.ViewModels
{
    public class ShipperForOrderViewModel
    {
        public ShipperAssignedForOrder ShipperAssignedForOrder { get; set; }
        public OrderBills Orders { get; set; }
        public IEnumerable<ApplicationUsers> Shipper { get; set; }
    }
}
