using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        const decimal LESSTHAN1000INTHREEDAYS = 60M;
        const decimal LESSTHAN1000INFIVEDAYS = 40M;
        const decimal LESSTHAN1000INSEVENDAYS = 40M;

        const decimal BETWEEN1000AND2000INTHREEDAYS = 70M;
        const decimal BETWEEN1000AND2000INFIVEDAYS = 50M;
        const decimal BETWEEN1000AND2000INSEVENDAYS = 50M;

        const decimal GRETERTHAN2000INTHREEDAYS = 80M;
        const decimal GRETERTHAN2000INFIVEDAYS = 60M;
        const decimal GRETERTHAN2000INSEVENDAYS = 40M;

        const decimal OAK = 200M;
        const decimal LAMINATE = 100M;
        const decimal PINE = 50M;
        const decimal ROSEWOOD = 300M;
        const decimal VENEER = 125M;
        const decimal DRAWERS = 50M;

        const decimal BASEPRICE = 200M;

        public enum Delivery {
            Rush3Days = 0,
            Rush5Days = 1,
            Rush7Days = 2,
            Normal14Days = 3
        }


        public decimal totalPrice { get; set; }
        public Desk desk = new Desk();
        public string customerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Delivery DeliveryType { get; set; }


        public void CalCost() {
            // Adding the base price
            totalPrice = 0M;
            totalPrice += BASEPRICE;

            int area = desk.Width * desk.Depth;
            // Adding the fee if area exceed 1000 square inch.
            if (area > 1000) { 
                int extraCost = (area - 1000)*1;
                totalPrice += (decimal)extraCost;
            }

            // Adding the delivey fee
            switch (DeliveryType) { 
                case Delivery.Rush3Days:
                    if (area < 1000) { totalPrice += LESSTHAN1000INTHREEDAYS; }
                    else if (area >= 1000 && area < 2000) { totalPrice += BETWEEN1000AND2000INTHREEDAYS; }
                    else totalPrice += GRETERTHAN2000INTHREEDAYS;
                        break;
                case Delivery.Rush5Days:
                    if (area < 1000) { totalPrice += LESSTHAN1000INFIVEDAYS; }
                    else if (area >= 1000 && area < 2000) { totalPrice += BETWEEN1000AND2000INFIVEDAYS; }
                    else totalPrice += GRETERTHAN2000INFIVEDAYS;
                    break;
                case Delivery.Rush7Days:
                    if (area < 1000) { totalPrice += LESSTHAN1000INSEVENDAYS; }
                    else if (area >= 1000 && area < 2000) { totalPrice += BETWEEN1000AND2000INSEVENDAYS; }
                    else totalPrice += GRETERTHAN2000INSEVENDAYS;
                    break;                
            }
            // Adding the drawer price
            totalPrice += (decimal)(desk.DrawerNum * 50);

            // Adding the material price.
            switch (desk.Material)
            {
                case Desk.Surface.Oak:
                    totalPrice += OAK;
                    break;
                case Desk.Surface.Laminate:
                    totalPrice += LAMINATE;
                    break;
                case Desk.Surface.Pine:
                    totalPrice += PINE;
                    break;
                case Desk.Surface.Rosewood:
                    totalPrice += ROSEWOOD;
                    break;
                case Desk.Surface.Veneer:
                    totalPrice += VENEER;
                    break;
            }
        }
    }
}
