using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Calculator
    {
        public  static void Add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine("Adding two numbers : " + res);
        }
        public static void Add(double a, double b,double c)
        {
            double res = a + b+c;
            Console.WriteLine("Adding two numbers : " + res);
        }
    }
}
