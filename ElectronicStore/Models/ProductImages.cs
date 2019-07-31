using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class ProductImages
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public virtual Products Products { get; set; }
        public string ImageUrl { get; set; }
    }
}
