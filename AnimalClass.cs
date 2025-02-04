using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class AnimalClass
    {
        public  void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    internal class Dog : AnimalClass
    {
        public void Sound()
        {
            Console.WriteLine("Barking... Woof Woof");
        }
    }
}
