using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Product
    {
        int prodId;
        string prodName;
        int prodPrice;
        public Product(int prodId, string prodName, int prodPrice)
        {
            this.prodId = prodId;
            this.prodName = prodName;
            this.prodPrice = prodPrice;
        }


    }
    internal class Cart
    {
        public void Adding()
        {

        }
        public void Removing()
        {

        }

       
    }
    internal class Customer
    {
        string custName;
        int custId;
        int custAge;
        public Customer(string custName, int custId, int custAge)
        {
            this.custName = custName;
            this.custId = custId;
            this.custAge = custAge;
        }
        public void PlaceOrder()
        {
            Console.WriteLine("Order Placed Successfully");
        }
    }

    internal abstract class Payments
        {
         abstract public void ProcessPayment();

        }
        internal class CreditCardpay : Payments
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment Processed through Credit Card");
            }
        }
        internal class Cashpay : Payments
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment Processed through Cash");
            }
        }
        internal class OnlinePay : Payments
        {
            public override void ProcessPayment()
            {
                Console.WriteLine("Payment Processed through Online");
            }
        }
    
}
