using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EMP_Wage
{
    class Total_wage_of_finel
    {
        public interface IComputeEmpWage
        {
            public void CompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month);
            public void ComputeEmpWage();
            public int getTotalWage(string company);
        }
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
                this.totalEmpWage = 0;
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
    }

    public class EmpWageBuilder:IComputeEmpWage
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private LinkedList<CompanyEmpWage> CompanyEmpWageList;
        private Dictionary<string, CompanyEmpWage> CompanyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.CompanyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            CompanyEmpWage CompanyEmpWage = new CompanyEmpWage(company, Emp_Rate_Per_Hour, Num_Of_Working_Days, Max_Hrs_In_Month);
            this.CompanyEmpWageList.AddLast(CompanyEmpWage);
            this.CompanyToEmpWageMap.Add(company, CompanyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
            {
                CompanyEmpWage.setTotalEmpWage(this.ComputeEmpWage(CompanyEmpWage));
                Console.WriteLine(CompanyEmpWage.toString());
            }
        }

        public int ComputeEmpWage(CompanyEmpWage CompanyEmpWage)
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
        public int getTotalWage(String company)
        {
            return this.CompanyToEmpWageMap[company].totalEmpWage;
        }

    static void Main(string[] args)
    {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart ", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance ", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total wage for DMart company : " + EmpWageBuilder.getTotalWage("DMart"));
    }
}
