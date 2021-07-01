using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class UC3_PartTimeEmpWage
    {
        public static void PartTime()
        {
            // Constants
            int Is_Part_Time = 1;
            int Is_Full_Time = 2;
            int Emp_Rate_Per_Hour = 20;
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Part_Time)
            {
                empHrs = 4;
            }
            else if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
