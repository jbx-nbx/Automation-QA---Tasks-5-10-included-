using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dev1;

namespace Dev1.UnitTest
{
    [TestClass]
    public class M2023AvivMoedATests
    {

        [TestMethod]
        public void q5_brothers_13and123_ReturnTrue()
        {
            //Arrange
            int x = 13, y = 123;
            bool actual, expected=true;
        
            //Act
            actual = M2023AvivA.q5_Brothers(x, y);

            //Assert
            Assert.AreEqual(expected, actual,"13 and 123 are brothers!!");
        }

        [TestMethod]
        public void q5_brothers_357and34567_ReturnTrue()
        {
            //Arrange
            int x = 357,y = 34567;
            bool actual, expected=true;

            //Act
            actual = M2023AvivA.q5_Brothers(x, y);

            //Assert
            Assert.AreEqual(expected, actual," 357 and 34567 are Brothers!!!");
        }

        [TestMethod]
        public void q5_brothers_6and6007_ReturnFalse()
        {
            //Arrange
            int x = 6,y=6007;
            bool actual, expected=false;

            //Act
            actual = M2023AvivA.q5_Brothers( x,  y);

            //Assert
            Assert.AreEqual(expected, actual, "6 and 6007 are not Brothers!!");
        }
        [TestMethod]
        public void q5_brothers_17and123_ReturnFalse()
        {
            //Arrange
            int x = 17, y = 123;
            bool actual, expected=false;
            
            //Act
            actual = M2023AvivA.q5_Brothers( x, y);
            
            //Assert

            Assert.AreEqual(expected, actual, "17 and 123 are not brothers!");
        }
    }
}
