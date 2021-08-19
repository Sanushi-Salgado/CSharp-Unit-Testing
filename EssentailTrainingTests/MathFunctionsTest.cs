using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;
using System;

namespace EssentailTrainingTests
{
    [TestClass]
    public class MathFunctionsTest
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            MathFunctions testInstance = new MathFunctions();
            double testResult = testInstance.Add(10, 4);
            Assert.AreEqual(14, testResult, "Test Failed! Expected result is 14.");
        }

        [TestMethod]
        public void Test_SubtractMethod()
        {
            MathFunctions testInstance = new MathFunctions();
            double testResult = testInstance.Subtract(10, 4);
            Assert.AreEqual(6, testResult, "Test Failed! Expected result is 6.");
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            MathFunctions testInstance = new MathFunctions();
            double testResult = testInstance.Multiply(10, 4);
            Assert.AreEqual(40, testResult, "Test Failed! Expected result is 40.");
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            MathFunctions testInstance = new MathFunctions();
            try
            {
                double testResult = testInstance.Divide(10, 0);
                Assert.AreEqual(2, testResult, "Test Failed!");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
