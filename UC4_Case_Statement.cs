using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class UC4_Case_Statement
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        
        public static void case_statement()
        { //varables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computaion
            int empCheck = random.Next(0, 3);
            switch(empCheck)
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


    }
}
