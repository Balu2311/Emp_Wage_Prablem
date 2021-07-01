using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class UC10_Emp_wage_multi_comp
    {
        public class CompanyEmpWage
        {
            public string company;
            public int Emp_Rate_Per_Hour;
            public int Num_Of_Working_Days;
            public int Max_Hrs_In_Month;
            public int totalEmpWage;

            public CompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
            {
                this.company = company;
                this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
                this.Num_Of_Working_Days = Num_Of_Working_Days;
                this.Max_Hrs_In_Month = Max_Hrs_In_Month;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return " Total of Emp Wage for company : " + this.company + "is: " + this.totalEmpWage;
            }
        }
    
    static void Main(string[] args)
    {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart ", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance ", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();


    }

    public class EmpWageBuilderArray
    {
            public const int Is_Part_Time = 1;
            public const int Is_Full_Time = 2;

            private int num_of_company = 0;
            private CompanyEmpWage[] CompanyEmpWageArray;

            public EmpWageBuilderArray()
            {
                this.CompanyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
            {
                CompanyEmpWageArray[this.num_of_company] = new CompanyEmpWage(company, Emp_Rate_Per_Hour, Num_Of_Working_Days, Max_Hrs_In_Month);
                num_of_company++;
            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < num_of_company; i++)
                {
                    CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.EmpWageBuilderArray[i]));
                    Console.WriteLine(this.CompanyEmpWageArray[i].toString());
                }
            }
            public int ComputeEmpWage(ComputeEmpWage ComputeEmpWage)
            {
                //varables
                int empHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
                //Computaion
                while (TotalEmpHrs <= CompanyEmpWage.Max_Hrs_In_Month && TotalWorkingDays < CompanyEmpWage.Num_Of_Working_Days)
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
                return TotalEmpHrs * CompanyEmpWage.Emp_Rate_Per_Hour;

            }
        }
    }
}
