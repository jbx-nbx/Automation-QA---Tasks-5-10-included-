using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dev1;
namespace Dev1.UnitTest
{
    [TestClass]
    public class HW11Tests
    {
        [TestMethod]
        public void FindMaxInArr_EmptyArr_ReturnMinValue()
        {
            int[] arr = { };
            int expected = int.MinValue;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }

        [TestMethod]
        public void FindMaxInArr_Null_ReturnMinValue()
        {
            int[] arr = null;
            int expected = int.MinValue;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }

        [TestMethod]
        public void FindMaxInArr_IntArrAllNegative_ReturnMaxValue()
        {
            int[] arr = { -112, -34, -17, -28 };
            int expected = -17;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }

        [TestMethod]
        public void FindMaxInArr_SameValueArr_ReturnSameValue()
        {
            int[] arr = { 2, 2, 2, 2, 2 };
            int expected = 2;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }

        [TestMethod]
        public void FindMaxInArr_IntArrIncludeMaxValue_ReturnSameValue()
        {
            int[] arr = { 2, 4, 6, 8, 10, -3, int.MaxValue };
            int expected = int.MaxValue;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }

        [TestMethod]
        public void FindMaxInArr_SingleValueArr_ReturnSameValue()
        {
            int[] arr = { 6 };
            int expected = 6;

            int actual = HW11.GetMaxValInIntArr(arr);

            Assert.AreEqual(expected, actual, $"Expected value: {expected}, but Actual value: {actual}");
        }
    }
}
