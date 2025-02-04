using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class ReactangleCal
    {
        private int length;
        private int breadth;
        public ReactangleCal(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public int Area()
        {
            return length * breadth;
        }
        
    }
}
