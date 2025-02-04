using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class MethodOverloading
    {
        public static void add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine("Addition of two numbers is: " + res);
        }
        public static void add(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine("Addition of three numbers is: " + res);
        }
        public static void add(int a, int b, int c, int d)
        {
            int res = a + b + c + d;
            Console.WriteLine("Addition of four numbers is: " + res);
        }
    }
}
