using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class UC9_Wage_of_each_company
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart ", 20, 2, 10);
            EmpWageBuilderObject relinace = new EmpWageBuilderObject("Reliance ", 10, 4, 20);
            dMart.Wage_Each_company();
            Console.WriteLine(dMart.toString());
            relinace.Wage_Each_company();
            Console.WriteLine(relinace.toString());
        }
    }

    public class EmpWageBuilderObject
    {
            public const int Is_Part_Time = 1;
            public const int Is_Full_Time = 2;

            private String company;
            private int Emp_Rate_Per_Hour;
            private int Num_Of_Working_Days;
            private int Max_Hrs_In_Month;
            private int TotalEmpWage;

            public EmpWageBuilderObject(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
            {
                this.company = company;
                this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
                this.Num_Of_Working_Days = Num_Of_Working_Days;
                this.Max_Hrs_In_Month = Max_Hrs_In_Month;
            }
            public void Wage_Each_company()
            {
                //varables
                int empHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
                //Computaion
                while (TotalEmpHrs <= Max_Hrs_In_Month && TotalWorkingDays < Num_Of_Working_Days)
                {
                    TotalWorkingDays++;
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
                    TotalEmpHrs += empHrs;
                    Console.WriteLine("Days#: " + TotalWorkingDays + "  empWage : " + empHrs);
                }
                TotalEmpWage = TotalEmpHrs * this.Emp_Rate_Per_Hour;
                Console.WriteLine("Total Emp Wage for company : " + company + "is :" + TotalEmpWage);
            }
         public string toString()
        {
            return " Total of Emp Wage for company : " + this.company + "is: " + this.TotalEmpWage;
        }
    }
}
