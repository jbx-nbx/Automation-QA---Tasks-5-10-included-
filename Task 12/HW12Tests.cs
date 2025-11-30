using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dev1;
namespace Dev1.UnitTest
{
    [TestClass]
    public class HW12Tests
    {
        [TestMethod]
        public void calcArrAvg_EmptyArr_ReturnMinValue()
        {
            //Arrange
            double[] arrToChk = { };
            HW12 myCode = new HW12();
            double actual,
                exepcted = double.MinValue;
            //Act
            actual = myCode.calArrAvg(arrToChk);

            //Assert
            Assert.IsFalse(exepcted == actual, " you should have got min value result ");

        }

        [TestMethod] //
        public void calcArrAvg_SingleNum_ReturnItem() //return the single item in the array
        {

            //Arrange
            double[] arrToChk = { 45 };
            HW12 myCode = new HW12();
            double actual,
                exepcted = double.MinValue;
            //Act - 
            actual = myCode.calArrAvg(arrToChk);

            //Assert - checking if if the expected and actual are equal
            Assert.IsFalse(exepcted == actual, " you should have got min value result ");

        }

    }
}
