using ARMLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ARMLibraryTest
{
    [TestClass]
    public class ARMLibraryClassTest
    {
        readonly Core db = new Core();
        [TestMethod]
        public void TestSuccessfulAddDepartment()
        {

            // Arrange
            Core departments = new Core()
            {
                Name = "Тест",
            };
            // Act
            bool result = departamentController.AddDepartment(departments);
            // Assert
            Assert.IsTrue(result);
        }
    }
}
