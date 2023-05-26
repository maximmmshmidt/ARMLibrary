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
        [TestMethod]
        public void Author_FIO_true()
        {
            //Arrange
            string FIO = "Тест Тест Тест";
            //Act
            bool actual = AddAuthor.Reg_FIO(FIO);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Author_FIO_False()
        {
            //Arrange
            string FIO = "Тест Тест; Тест!";
            //Act
            bool actual = AddAuthor.Reg_FIO(FIO);
            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Проверка на книгу
        /// </summary>
// Reg_NameBook
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
        [TestMethod]
        public void Book_Name_a()
        {
            //Arrange
            string name = "тест";
            //Act
            bool actual = AddBook.Reg_NameBook(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Name_aS()
        {
            //Arrange
            string name = "Тест";
            //Act
            bool actual = AddBook.Reg_NameBook(name);
            //Assert
            Assert.IsTrue(actual);
        }
//Gg_IBN
        [TestMethod]
        public void Book_Names()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Gg_IBN(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Namess()
        {
            //Arrange
            string name = "asd";
            //Act
            bool actual = AddBook.Gg_IBN(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_ibn()
        {
            //Arrange
            string name = "1111111111";
            //Act
            bool actual = AddBook.Gg_IBN(name);
            //Assert
            Assert.IsTrue(actual);
        }
//Reg_PlacePublication
        [TestMethod]
        public void Book_Names_Reg_PlacePublication()
        {
            //Arrange
            string name = "1111111111";
            //Act
            bool actual = AddBook.Reg_PlacePublication(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_PlacePublications()
        {
            //Arrange
            string name = "trf";
            //Act
            bool actual = AddBook.Reg_PlacePublication(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_PlacePublicationss()
        {
            //Arrange
            string name = ";'";
            //Act
            bool actual = AddBook.Reg_PlacePublication(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_PlacePublicationsfs()
        {
            //Arrange
            string name = "Екатеринбург";
            //Act
            bool actual = AddBook.Reg_PlacePublication(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_PlacePublicat()
        {
            //Arrange
            string name = "г.Екатеринбург";
            //Act
            bool actual = AddBook.Reg_PlacePublication(name);
            //Assert
            Assert.IsTrue(actual);
        }
//Reg_PublishingHouse
        [TestMethod]
        public void Book_Names_Reg_PublishingHouse()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Reg_PublishingHouse(name);
            //Assert
            Assert.IsFalse(actual);
        }
//Reg_PublishingHouse
        [TestMethod]
        public void Book_Names_Reg_BBK()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Reg_PublishingHouse(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_BBKs()
        {
            //Arrange
            string name = "46.73";
            //Act
            bool actual = AddBook.Reg_PublishingHouse(name);
            //Assert
            Assert.IsFalse(actual);
        }


        /// <summary>
        /// Проверка на Пользователя
        /// </summary>
        [TestMethod]
        public void User_FIO()
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
