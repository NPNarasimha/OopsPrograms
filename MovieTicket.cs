using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class MovieTicket
    {
    public void Tickets()
        {
            Console.WriteLine("Enter the Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time of movie 1 to 24");
            int time= Convert.ToInt32(Console.ReadLine());
            int price = 0;
            int discount = 0;
            int ticPrice = 20;

            if (age > 0 && age <= 12)
            {
                discount = 7;
                price = ticPrice - discount;
                Console.WriteLine("Children Ticket price is : ");
            }
            else if(age > 12 && age <= 64) 
            {
                discount = 5;
                price = ticPrice - discount;
                Console.WriteLine("Adult Ticket price is : " );
            }
            else
            {
                discount = 4;
                price = ticPrice - discount;
                Console.WriteLine("Senior citizen Ticket price is : " );
            }

            if (time < 17)
            {
                price -= 2;
                Console.Write(price);
            }
            else
            {
                price -= 1;
                Console.Write(price);
            }
        }
    }
}
