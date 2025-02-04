using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class InheritanceProgram
    {
        public static void Adding() 
        {
           int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Addition of two numbers is: " + c);
        }
    }
    class InheritanceProgramApp : InheritanceProgram
    {
        public static void Subtracting()
        {
            int a = 20;
            int b = 10;
            int c = a - b;
            Console.WriteLine("Subtraction of two numbers is: " + c);
        }
    }
}
