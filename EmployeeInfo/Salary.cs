using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    internal class Salary
    {
        public float basicSalary;
        public float hoursRent;
        public float medicalAllowance;
        public float conveyance;

        double bsPerson;
        double hrPerson;
        double maPersent;
        double caPersent;

        /* overtime caculate */
        public float overtime;
        public double overtimeRet;
        public double totalOvertimeRet;
        public double CalculateSalary(float basicSalary)
        {
            this.bsPerson = 0.50;
            this.hrPerson = 0.20;
            this.maPersent = 0.25;
            this.caPersent = 0.05;

            this.basicSalary = basicSalary;
            this.hoursRent =Convert.ToInt32(basicSalary * hrPerson);
            this.medicalAllowance = Convert.ToInt32(basicSalary * maPersent);
            this.conveyance = Convert.ToInt32(basicSalary * caPersent);
            var totalSalary = this.basicSalary + this.hoursRent + this.medicalAllowance +this.conveyance;
            this.currency = Currency.BDT;
            return totalSalary;
        }
        public double CalculateByOverTime(double overtime)
        {
            this.overtime = basicSalary;
            var ot = (((overtime / 30) / 8) * 2 * 8);
            return ot;
        }
        public Currency currency;
    }
    public enum Currency
    {
        BDT , RS , USD , EURO , CNY , YEN
    }
}
