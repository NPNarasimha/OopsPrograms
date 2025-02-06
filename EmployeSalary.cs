using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class EmployeSalary
    {
      
        public static void Employee()
        {
            Random rand = new Random();
            int empAttend = rand.Next(0, 2);
            int workHrs = 0;
            int hWage = 20;
            int workingDays = 20;
                switch (empAttend)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        workHrs = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present");
                        int empType = rand.Next(0, 2);
                        if (empType == 0)
                        {
                            workHrs = rand.Next(0, 8);
                        int TotalEmpWage = hWage * workHrs;
                            Console.WriteLine("Employee Part Time Wage is: " + TotalEmpWage);
                        }
                        else
                        {
                            Console.WriteLine("Employee is Full Time");
                            
                            workingDays = rand.Next(0, 20);
                            workHrs = rand.Next(0, 100);
                            if (workingDays == 20 || workHrs == 100)
                            {
                                
                                int TotalEmpWage = workHrs * hWage;
                                Console.WriteLine("Employee Working for 20 Days Wage is: " + TotalEmpWage);
                            }
                            else
                            { 
                                int TotalEmpWage = hWage * workHrs * workingDays;
                                Console.WriteLine("Employee Working for Less than 20 Days Wage is: " + TotalEmpWage);
                            }
                        }
                        break;
                
            }
        }
    }
}
