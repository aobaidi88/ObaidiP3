using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObaidiP3.Shared
{
    public class InvestmentCalc
    {
        private int cmpPerYr;
        private double intrest;
        private double principle;
        private int years;

        public int CmpPerYr { get { return cmpPerYr; } set { cmpPerYr = value; Calc(); } }  
        public int Years { get { return years; } set { years = value; Calc(); } }
        public double Intrest { get { return intrest; } set { intrest = value; Calc(); } }
        public double Principle { get { return principle; } set { principle = value; Calc(); } }
        public double FutureValue { get; set; }

        public InvestmentCalc()
        {
        }

        public InvestmentCalc(double principle, int years, double intrest, int numTimes)
        {
            InvestmentCalc investmentCalc = this;
            investmentCalc.Intrest = intrest;
            investmentCalc.Years = years;
            investmentCalc.Principle = principle;
            investmentCalc.CmpPerYr = numTimes;
        }

        public void Calc()
        {
            double amount;
            double nt = (cmpPerYr * years);
            double bace = (1 + (intrest / cmpPerYr));
            amount = Math.Pow(bace, nt);
            FutureValue = (Principle * amount);
        }
    }
}
