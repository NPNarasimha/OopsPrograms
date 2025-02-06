using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class BasicCalculator
    {
        public void calculation()
        {
            Console.WriteLine("Enter the num1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operations : + --> addition , - -->substraction , * -->multiplication , / --> division");
            Char operation = Convert.ToChar(Console.ReadLine());
            int res = 0;
            switch (operation)
            {
                case '+': res = n1 + n2;
                    Console.WriteLine("Addition of Two Numbers : " + res);
                    break;
                case '-':
                    if (n1 > n2)
                    {
                        res = n1 - n2;
                        Console.WriteLine("Substraction of Two Numbers : " + res);
                    }
                    else
                    {
                        res = n2 - n1;
                        Console.WriteLine("Substraction of Two Numbers : " + res);
                    }
                    break;
                case '*':
                    res = n1 * n2;
                    Console.WriteLine("Multiple of Two Numbers : " + res);
                    break;
                case '/':
                    res = n1 / n2;
                    Console.WriteLine("Division of Two Numbers : " + res);
                    break;

                default:
                   Console.WriteLine("Invalid Operation");
                    break;
            }
        }
    }
}
