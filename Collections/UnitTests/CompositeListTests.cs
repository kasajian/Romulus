using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.AnalyzerExcelAddInTests
{
    [TestClass]
    public class CompositeListTests
    {
        [TestMethod]
        public void CompositeList_Test()
        {
            var book = new List<List<int>>
            {
                new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
                new List<int> {10, 11, 12, 13, 14, 15, 16, 17, 18, 19},
                new List<int> {20, 21, 22, 23, 24, 25, 26, 27, 28, 29}
            };

            var compositeList = new CompositeList(book);

            Assert.AreEqual(30, compositeList.Count);

            Assert.AreEqual(0, compositeList[0]);
            Assert.AreEqual(10, compositeList[10]);
            Assert.AreEqual(20, compositeList[20]);
            Assert.AreEqual(29, compositeList[29]);
            Assert.AreEqual(3, compositeList[3]);
            Assert.AreEqual(16, compositeList[16]);
            Assert.AreEqual(11, compositeList[11]);
            Assert.AreEqual(9, compositeList[9]);
            Assert.AreEqual(19, compositeList[19]);
        }

        [TestMethod]
        public void CompositeList_Test2()
        {
            var book = new List<List<int>>
            {
                new List<int> {0, 11, 22, 33, 44, 55},
                new List<int> {66, 77},
                new List<int> {88, 99, 1010, 1111, 1212, 1313}
            };

            var compositeList = new CompositeList(book);

            Assert.AreEqual(14, compositeList.Count);

            Assert.AreEqual(0, compositeList[0]);
            Assert.AreEqual(11, compositeList[1]);
            Assert.AreEqual(22, compositeList[2]);
            Assert.AreEqual(33, compositeList[3]);
            Assert.AreEqual(44, compositeList[4]);
            Assert.AreEqual(55, compositeList[5]);
            Assert.AreEqual(66, compositeList[6]);
            Assert.AreEqual(77, compositeList[7]);
            Assert.AreEqual(88, compositeList[8]);
            Assert.AreEqual(99, compositeList[9]);
            Assert.AreEqual(1010, compositeList[10]);
            Assert.AreEqual(1111, compositeList[11]);
            Assert.AreEqual(1212, compositeList[12]);
            Assert.AreEqual(1313, compositeList[13]);
        }
    }
}
