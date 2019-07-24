using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models.ViewModels
{
    public class ShipperForOrderViewModel
    {
        public OrderBills Order { get; set; }
        public List<ApplicationUsers> Shipper { get; set; }
    }
}
