using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WGDataManager.Models
{
    public class SaleModel
    {
        public char Id { get; set; }
        public string Description { get; set; }
        public int Subtotal { get; set; }
        public int Total { get; set; }
    }
}