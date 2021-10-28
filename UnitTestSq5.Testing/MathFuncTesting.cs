using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestSQ5.Service;

namespace UnitTestSq5.Testing
{
    [TestClass]
    public class MathFuncTesting
    {
        [TestMethod]
        public void MathFunc_Sum_30()
        {
            var sum = MathFunc.Sum(20, 10);
            Assert.AreEqual(30, sum);
        }
        [TestMethod]
        public void MathFunc_Factorial_SmallerthanOne_One()
        {
            var result = MathFunc.Fatorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void MathFunc_Factorial_BiggerThanOne_N()
        {
            var result = MathFunc.Fatorial(4);
            Assert.AreEqual(24, result);
        }
    }
}
