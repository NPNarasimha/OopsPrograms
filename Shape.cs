using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Shape
    {
        public static void GetArea()
        {
            Console.WriteLine("Area of Shape");
        }
    }
    internal class Circle : Shape
    {
        
        public  void GetArea()
        {
            int r = 5;
            double res = Math.PI * (r * r); 
            Console.WriteLine("Area of Circle " +res);
        }
    }
    internal class Square : Shape
    {
        public  void GetArea()
        {
            int s = 5;
            int res = s * s;
            Console.WriteLine("Area of Square " + res);
        }
    }
}
