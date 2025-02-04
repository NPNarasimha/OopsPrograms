using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Student
    {
        private string name;
        private int age;
        
       public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
            if (age >= 1)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age should not in negitive");

            }
        }
        public void getName()
        {
            Console.WriteLine("Name is : " + name);
        }
        public void getAge()
        {
            Console.WriteLine("Age is : " + age);
        }
    }
}
