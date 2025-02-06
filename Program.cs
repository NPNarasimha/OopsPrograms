using System;

namespace OopsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InheritanceProgramApp.Adding();
            //InheritanceProgramApp.Subtracting();

            /*Encapsulation e = new Encapsulation("Raj", 20, 101);
            e.getName();
            e.getAge();
            e.getId();
            */

            /* MethodOverloading.add(10, 20);
             MethodOverloading.add(10, 20, 30);
             MethodOverloading.add(10, 20, 30, 40);
             */

            //MethodOverriding 
            /*AnimalClass a = new Dog();
            a.Sound();
        */
            //AbstractClass
            /*    Developers d = new Developers();
                d.dotNetDeveloper();    
                d.javaDeveloper();
            */
            //AbstractInterface

            /*Application a = new Application();
            a.farmer();
            a.doctor(); 
            a.jober();
            a.enginer();
            a.Degree();
            */

            //EmployeSalary.Employee();

           /* MovieTicket mt= new MovieTicket();
            mt.Tickets();
           */
          
            /*Validation v=new Validation();
            v.UserValidation();
            */

          /*  BasicCalculator calculator = new BasicCalculator();
            calculator.calculation();
          */

            AirQualityCal a = new AirQualityCal();
            a.CalculateAirQuality();
        }
    }
}
