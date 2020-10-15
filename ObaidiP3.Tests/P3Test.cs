using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObaidiP3.Shared;


namespace ObaidiP3.Tests
{
    [TestClass]
    public class P3Test
    {
        [TestMethod]
        public void TestTheFormula()
        {
            InvestmentCalc investment = new InvestmentCalc();
            double principle = 5000;
            int years = 10;
            double intrest = 0.05;
            int numTimes = 12;
            double amount;
            double FutureValue;
            double nt = numTimes * years;
            double bace = (1 + (intrest / numTimes));
            amount = System.Math.Pow(bace, nt);
            FutureValue = (principle * amount);
            Assert.AreEqual(FutureValue, 8235.0474884514);
        }
    }
}
