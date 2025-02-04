using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class OnlineStore
    {
       
        string prodName;
         double prodPrice;
         int prodquantity;
        public OnlineStore(string prodName, double prodPrice, int prodquantity)
        {
            this.prodName = prodName;
            this.prodPrice = prodPrice;
            this.prodquantity = prodquantity;
        }
        
        public  void quantityAdjest(int quantity)
        {
            prodquantity += quantity;
            Console.WriteLine("Quantity is : " + prodquantity);
        }
        public  void totalAmt()
        {
            double total = 0;
            total = prodquantity * prodPrice;
            Console.WriteLine("Total Amount is : " + total);
        }
    }
}
