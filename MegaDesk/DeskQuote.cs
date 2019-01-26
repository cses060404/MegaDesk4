using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        public Desk desk = new Desk();
        public int RushDays { get; set; }
        public string customerName { get; set; }
        public DateTime QuoteDate { get; set; }
        private double price { get; set; }


        public double CalCost() {
            return price;
        }
    }
}
