using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 2, 4, 8, 5, 465, 678, 9, 345, 234, 234, 467, 78, 3, 2, 4, 6, 7, 89, -10, 0, 100, 101 };
            Sort.simpleSort(array);
            for (int i = 1; i < array.Length; i++ )
            {
                if(array[i]<array[i-1])
                    Assert.IsTrue(false);
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 2, 4, 8, 5, 465, 678, 9, 345, 234, 234, 467, 78, 3, 2, 4, 6, 7, 89, -10, 0, 100, 101,1 };
            Sort.simpleSort(array);
            Assert.AreEqual(array.Length, 23);
        }
    }
}
