using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Grocery
    {
        public string ItemName { set; get; }
        public string ItemCode { set; get; }
        public int StartingQty { set; get; }
        public int QtyMinForRestock { set; get; }
        public int QtySold { set; get; }
        public int QtyRestocked { set; get; }
        public float UnitPrice { set; get; }
        public int QuantityOnHand
        {
            get
            {
                return StartingQty - QtySold + QtyRestocked;
            }
        }
        public float TotalSales
        {
            get
            {
                float totalSales = 0;
                totalSales= QtySold * UnitPrice;
                return totalSales;
            }
        }
        public Grocery(string itemName, string itemCode, int startingQty, int qtyMinForRestock, int qtySold,
                       int qtyRestocked, float unitPrice)
        {
            ItemName = itemName;
            ItemCode = itemCode;
            StartingQty = startingQty;
            QtyMinForRestock = qtyMinForRestock;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;
            UnitPrice = unitPrice;
        }
        public override string ToString()
        {

            string outputStr = "";
            outputStr += ItemName.PadRight(25, ' ');
            outputStr += ItemCode.PadRight(17, ' ');
            outputStr += UnitPrice.ToString().PadRight(17, ' ');
            outputStr += StartingQty.ToString().PadRight(17, ' ');
            outputStr += QtyMinForRestock.ToString().PadRight(17, ' ');
            outputStr += QtySold.ToString().PadRight(17, ' ');
            outputStr += QtyRestocked.ToString().PadRight(17, ' ');
            outputStr += QuantityOnHand.ToString().PadRight(17, ' ');
            outputStr += TotalSales.ToString().PadRight(17, ' ');
            return outputStr;
        }
    }
}
