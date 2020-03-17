using System;
using Technical_Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class TechnicalQuestions
    {
        [TestMethod]
        public void tBinarySearch()
        {
            var test1 = new int[] { 2,4,6,7,10};
            var test2 = new int[] { 0 };
            var test3 = new int[] { 2, 4, 6, 8, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 100 };
            var success1 = 1;
            var success2 = -1;
            var success3 = 10;

            Assert.AreEqual(success1, BinarySearch.Search(test1, 4));
            Assert.AreEqual(success2, BinarySearch.Search(test2, 1));
            Assert.AreEqual(success3, BinarySearch.Search(test3, 17));
        }

        [TestMethod]
        public void tMergeSort()
        {
            List<int> test1 = new List<int>() { 10, 9, 8, 7, 6 };
            List<int> success1 = new List<int>() { 6, 7, 8, 9, 10 };
            List<int> merged1 = MergeSort.Sort(test1);
            bool equals = true;

            for (int i = 0; i < success1.Count; i++)
            {
                if (success1[i]!=merged1[i])
                {
                    equals = false;
                    break;
                }
            }

            Assert.IsTrue(test1.Count == success1.Count && equals);
        }
    }
}
