using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dev1;

namespace Dev1.UnitTest
{
    [TestClass]
    public class ChkIfArrIsPrime2Tests
    {
        [TestMethod]
        public void TestChkIfArrChkIfArrIsPrime2_PrimeArr_ReturnTrue()
        {
            //Arrange
            int[] numbers = { 10, -34, 13, 17, 124, 11, 17 };
            //Act
            bool result = Dev1.isPrime.ChkIfArrIsPrime2(numbers);
            //Assert
            Assert.IsTrue(result, "The input array should be declared as Prime array !!!!");
        }

        [TestMethod]
        public void TestChkIfArrChkIfArrIsPrime2_PrimeNotArr_ReturnFalse()
        {
            //Arrange
            int[] numbers = { 10, -34, 130, 170, 124, 11, 17 };
            //Act
            bool result = Dev1.isPrime.ChkIfArrIsPrime2(numbers);
            //Assert
            Assert.IsFalse(result, "The input array should be declared as Not Prime array !!!! ");
        }

        [TestMethod]
        public void TestChkIfArrChkIfArrIsPrime2_EmptyArr_ReturnFalse()
        {
            //Arrange
            int[] numbers = { };
            //Act
            bool result = Dev1.isPrime.ChkIfArrIsPrime2(numbers);
            //Assert
            Assert.IsFalse(result, "Empty array should be declared as Not Prime array !!!! ");
        }

        [TestMethod]
        public void TestChkIfArrChkIfArrIsPrime2_Null_ReturnFalse()
        {
            //Arrange
            int[] numbers = null;
            //Act
            bool result = Dev1.isPrime.ChkIfArrIsPrime2(numbers);
            //Assert
            Assert.IsFalse(result, "NULL array should be declared as Not Prime array !!!! ");
        }

        [TestMethod]
        public void TestChkIfArrChkIfArrIsPrime2_PrimeArrSimilarPrimItemAndNotPrimItems_ReturnFalse()
        {
            //Arrange
            int[] numbers = null;
            //Act
            bool result = Dev1.isPrime.ChkIfArrIsPrime2(numbers);
            //Assert
            Assert.IsFalse(result, "the input array should be declared prime array ");
        }

    }
}
