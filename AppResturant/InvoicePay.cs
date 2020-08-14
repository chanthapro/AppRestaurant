using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppResturant
{
    class InvoicePay
    {
        public int No { get; set; }
        public string fnamekh { get; set; }
        public string fnamecn { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public string des { get; set; }
        public double amount { get { return qty * price; } }
    }
}
