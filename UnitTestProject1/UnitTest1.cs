using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quize_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int[] array1 = new int[] { 1, 1, 2, 2, 3, 4, 4, 5 };
        int[] array3 = new int[] { 1, 1, 2, 2,4,4};
        int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };

        [TestMethod]        
        public void TestMethod1()
        {
            var result = Program.GetUniqueElement(array1);
            Assert.AreEqual(3, result);
            var result1 = Program.GetUniqueElement(array3);
            Assert.AreEqual(0, result1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = Program.IsContainDubplicateEelement(array1);
            Assert.AreEqual(false, result);
            var result1 = Program.IsContainDubplicateEelement(array2);
            Assert.AreEqual(true, result1);
        }
    }
}
