using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal interface AbstractInterface
    {
        public void farmer();
        public void doctor();
        public void jober();
    }

    interface Study
    {
        public void enginer();
        public void Degree();
        
    }
    class Application: AbstractInterface, Study
    {
        public void farmer()
        {
            Console.WriteLine("Farmer is doing farming");
        }
        public void doctor()
        {
            Console.WriteLine("Doctor is doing treatment");
        }
        public void jober()
        {
            Console.WriteLine("Jober is doing job");
        }
        public void enginer()
        {
            Console.WriteLine("Enginer is doing enginering");
        }
        public void Degree()
        {
            Console.WriteLine("Degree is doing degree");
        }
    }
}
