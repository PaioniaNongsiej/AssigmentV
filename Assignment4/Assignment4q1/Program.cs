using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleDetails s = new SaleDetails(1, 1, 200, DateTime.Today, 3);
            Console.Read();
        }
        public class SaleDetails
        {
            private int SaleNo;
            private int ProductNo;
            private int Price;
            private DateTime DateofSales;
            private int Qty;
            private int TotalAmount;
            public SaleDetails(int SalesNo, int ProductNo, int Price, DateTime DateOfSales, int Qty)
            {
                this.SaleNo = SalesNo;
                this.ProductNo = ProductNo;
                this.Price = Price;
                this.DateofSales = DateOfSales;
                this.Qty = Qty;
                Sales();
                ShowData();
            }


            public void Sales()
            {
                this.TotalAmount = Qty * Price;
            }

            public void ShowData()
            {
                Console.WriteLine("SalesNo: " + this.SaleNo);
                Console.WriteLine("ProductNo: " + this.ProductNo);
                Console.WriteLine("Price: " + this.Price);
                Console.WriteLine("DateOfSale: " + this.DateofSales.ToShortDateString());
                Console.WriteLine("Qty: " + this.Qty);
                Console.WriteLine("TotalAmount: " + this.TotalAmount);
            }
        }
    }
}


