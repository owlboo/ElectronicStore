﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public class Coupons
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
