using ARMLibrary.Models;
using ARMLibraryClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ARMLibraryTest
{
    [TestClass]
    public class ARMLibraryClassTest
    {
        /// <summary>
        /// Проверка на автора
        /// </summary>
        [TestMethod]
        public void Author_FIO_Null()
        {
            //Arrange
            string FIO = "";
            //Act
            bool actual = AddAuthor.Reg_FIO(FIO);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на книгу
        /// </summary>
        [TestMethod]
        public void Book_Name()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Reg_NameBook(name);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на Пользователя
        /// </summary>
        [TestMethod]
        public void User()
        {
            //Arrange
            string FIO = "";
            //Act
            bool actual = AddUser.Reg_FIO(FIO);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
