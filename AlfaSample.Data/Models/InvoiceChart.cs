﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaSample.Data.Models
{
    public class InvoiceChart
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public decimal Day { get; set; }
        public decimal Night { get; set; }
        public decimal Weekend { get; set; }
    }
}
