using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class AirQualityCal
    {
        public void CalculateAirQuality()
        {
            Console.WriteLine("Enter the quality of Air range");
            Double Aqirange=Convert.ToDouble(Console.ReadLine());
            if (Aqirange >= 0.0 && Aqirange <= 50.0)
            {
                Console.WriteLine("Good " +Aqirange);
            }
            else if(Aqirange >= 50.0 &&  Aqirange <= 100.0)
            {
                Console.WriteLine("Modrate " + Aqirange);
            }
            else if (Aqirange >100.0 && Aqirange <= 150.0)
            {
                Console.WriteLine("UnHealthy " + Aqirange);
            }
            else
            {
                Console.WriteLine("Danger " + Aqirange);
            }
        }
    }
}
