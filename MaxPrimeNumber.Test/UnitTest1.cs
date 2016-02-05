using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxPrimeNumber.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly static TimeSpan _time = new TimeSpan(0, 0, 30);
        private readonly CalculateTool _tool = new CalculateTool(_time);

        [TestMethod]
        [Description("Argument test")]
        public void TestMethod1()
        {
            var n = 1;

            _tool.FindMaxPrime(n);
        }


        [TestMethod]
        [Description("Number test")]
        public void TestMethod2()
        {
            var n = (long)int.MaxValue;

            _tool.FindMaxPrime(n);
        }
    }
}
