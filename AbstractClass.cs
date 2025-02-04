using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal abstract class AbstractClass
    {
        abstract public void dotNetDeveloper();
        abstract public void javaDeveloper();
    }
    class Developers : AbstractClass
    {
        public override void dotNetDeveloper()
        {
            Console.WriteLine(".Net Developer doing .net Project");
        }
        public override void javaDeveloper()
        {
            Console.WriteLine("Java Developer doin java Project");
        }
    }
}
