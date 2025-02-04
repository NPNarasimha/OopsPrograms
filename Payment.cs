using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Payment
    {
        public void Pay()
        {
            Console.WriteLine("Payment is Successfully");
        }
    }
    internal class CreditCard : Payment
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Payment is Successfully");
        }
    }
    internal class Cash : Payment
    {
        public void Pay()
        {
            Console.WriteLine("Cash Payment is Successfully");
        }
    }
    internal class Online : Payment
    {
        public void Pay()
        {
            Console.WriteLine("Online Payment is Successfully");
        }
    }
    internal class Transtaction
    {
        
        public void Trans(Payment p)
        {  
            p.Pay();
        }
    }
}
