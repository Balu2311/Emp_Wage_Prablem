using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class UC5_Wage_of_Month
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;

        public static void Wage_of_Month()
        { //varables
            int empHrs = 0, empWage = 0, TotalEmpWage = 0;
            //Computaion
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                Console.WriteLine("EMP Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + TotalEmpWage);
        }
    }
}
