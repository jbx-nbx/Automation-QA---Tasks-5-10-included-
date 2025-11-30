using App1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Tests
{
    [TestClass]
    public class HW13Tests
    {
        [TestMethod]
        public void balanceCheck_null_ReturnTrue()
        {
            //Arrange
            int[] balance = null;
            //Act
            bool result = HW13.balancedNum(balance);
            //Assert

            Assert.IsFalse(result, "Null array should return False !!!!");
        }


        [TestMethod]
        public void balanceCheck_emptyArr_ReturnTrue()
        {
            //Arrange
            int[] balance = { };
            //Act
            bool result = HW13.balancedNum(balance);
            //Assert
            Assert.IsFalse(result, "Empty array should return False !!!!");
        }

        [TestMethod]
        public void balanceCheck_balancedArr_ReturnTrue()
        {
            //Arrange
            int[] balance = { -1, 2, -3, 4, -5, 6 };
            //Act
            bool result = HW13.balancedNum(balance);
            //Assert
            Assert.IsTrue(result, "Balanced array should return True !!!!");
        }

        [TestMethod]
        public void balanceCheck_notBalancedArr_ReturnFalse()
        {
            //Arrange
            int[] balance = { 1, 2, 3, 4, 5 };
            //Act
            bool result = HW13.balancedNum(balance);
            //Assert
            Assert.IsFalse(result, "Not Balanced array should return False !!!!");
        }

        [TestMethod]
        public void balanceCheck_singleElementArr_ReturnFalse()
        {
            //Arrange
            int[] balance = { 5 };
            //Act
            bool result = HW13.balancedNum(balance);
            //Assert
            Assert.IsFalse(result, "Single element array should return False !!!!");

        }
    }
}
