using Microsoft.VisualStudio.TestTools.UnitTesting;
using SofwareTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofwareTesting.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calc = new Calculator();
            var value = calc.Add(1, 1);

            Assert.AreEqual(2, value, "must be equal to 2 (1+1)");

            value = calc.Add(2, 0);
            Assert.AreEqual(2, value);

            value = calc.Add(-1, -3);
            Assert.AreEqual(-4, value);
        }

        [TestMethod()]
        public void DivTest()
        {
            var calc = new Calculator();
            var value = calc.Div(1, 1);

            Assert.AreEqual(1, value);

            value = calc.Div(3, 3);
            Assert.AreEqual(1, value);

            value = calc.Div(3, 2);
            Assert.AreEqual(1.5, value);

        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div0Test() {
            var calc = new Calculator();
            calc.Div(3, 0.0);
        }
    }
}