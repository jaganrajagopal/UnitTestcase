using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jenkinsdotnetprojects;

namespace CalculationNunit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTestCase()
        {
            CalculationProcess myCalc = new CalculationProcess();

            Assert.AreEqual(myCalc.Add(1, 2), 3);
        }
        [TestMethod]
        public void SubtractTestCase()
        {
            CalculationProcess myCalc = new CalculationProcess();

            Assert.AreEqual(myCalc.subtract(3, 1), 2);
        }
    }
}
