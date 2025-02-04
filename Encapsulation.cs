using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Encapsulation
    {
        private String sName ;
        private int sAge ;
        private int sId ;
        public Encapsulation(String sName, int sAge, int sId)
        {
            this.sName = sName;
            this.sAge = sAge;
            this.sId = sId;
        }
        public void getName()
        {
            Console.WriteLine("Student Name: " + sName);
        }
        public void getAge()
        {
            Console.WriteLine("Student Age: " + sAge);
        }
        public void getId()
        {
            Console.WriteLine("Student Id: " + sId);
        }

    }
}
