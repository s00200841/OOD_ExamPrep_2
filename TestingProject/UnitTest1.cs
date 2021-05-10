using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOD_ExamPrep_2;

namespace TestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Phone phone1 = new Phone("Samsung 250s", 500, "Android");
            decimal expectedPrice = 550;

            // Act
            phone1.IncreasePrice(.10);


            // Assert
            Assert.AreEqual(expectedPrice, phone1.Price);
        }
    }
}
