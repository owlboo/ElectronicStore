using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class OrderBills
    {
        public long Id { get; set; }
        public string BillName { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name ="Customer")]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual ApplicationUsers Customers { get; set; }
        public long ShippingFee { get; set; }
        public long TotalPrice { get; set; }
        public bool ShipperConfirm { get; set; }
        public bool Status { get; set; }
        //[Display(Name = "Coupon")]
        //public long CouponId { get; set; }
        //[ForeignKey("CouponId")]
        //public virtual Coupons Coupons { get; set; }

    }
}
