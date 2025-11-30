using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dev1;

namespace Dev1.UnitTest
{
    [TestClass]
    public class q7_ValidPhoneNumberTests
    {
        [TestMethod]
        public void q7__FirstThreeDigits_isValid()
        {
            //Arrange
            string pnum = "052-6579472";
                bool expected = true,
                actual;
             //Act
            actual = q7_isValidPhoneNumber.PhoneNumber_isValid(pnum);
            
            //Assert
            Assert.AreEqual(expected, actual,"");
        }

        [TestMethod]
        public void q7__FirstThreeDigits_isNotValid_ReturnsFalse()
        {
            //Arrange
            string pnum = "05A-6579472";
            bool actual;
            //Act
            actual = q7_isValidPhoneNumber.PhoneNumber_isValid(pnum);

            //Assert
            Assert.IsFalse(actual,"One of The first three digits is not a digit , please make sure all 1st three digits are numbers between 0-9");
        }

        [TestMethod]
        public void q7__7charsAfterDash_isNotValid_ReturnsFalse()
        {
            //Arrange
            string pnum = "052-65579472";
            bool actual;
            //Act
            actual = q7_isValidPhoneNumber.PhoneNumber_isValid(pnum);

            //Assert
            Assert.IsFalse(actual, "the last 7 chars are not are not exactly seven as exepected ");
        }


        [TestMethod]
        public void q7__ForthChar_isNotDash_ReturnsFalse()
        {
            //Arrange
            string pnum = "05276579472";
            bool actual;
            //Act
            actual = q7_isValidPhoneNumber.PhoneNumber_isValid(pnum);

            //Assert
            Assert.IsFalse(actual, "One of The fourth char is not a dash, please make sure the fourth char is Dash ","-");
        }

        [TestMethod]
        public void q7_NotAllSevenDigitsAreDigits_ReturnsFalse()
        {
            //Arrange
            string pnum = "052657Z472";
            bool actual;
            //Act
            actual = q7_isValidPhoneNumber.PhoneNumber_isValid(pnum);

            //Assert
            Assert.IsFalse(actual, "One of The fourth char is not a dash, please make sure the fourth char is Dash ", "-");
        }
    }
}
