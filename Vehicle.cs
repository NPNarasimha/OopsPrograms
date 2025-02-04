using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal abstract class Vehicle
    {
        abstract public void StartEngine();
    }
    internal class Car : Vehicle
    {

        public override void StartEngine()
        {
           Console.WriteLine("Car Engine Started");
        }
    }
    internal class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike Engine Started");
        }
    }
}
