using ARMLibrary.Models;
using ARMLibraryClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;

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
            string name = "59895430162";
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
            string name = "г Екатеринбург";
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
        [TestMethod]
        public void Book_Names_Reg_PublishingHousse()
        {
            //Arrange
            string name = "АВан";
            //Act
            bool actual = AddBook.Reg_PublishingHouse(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_PublishingHouses()
        {
            //Arrange
            string name = "Авын";
            //Act
            bool actual = AddBook.Reg_PublishingHouse(name);
            //Assert
            Assert.IsTrue(actual);
        }
//Reg_PublishingHouse
        [TestMethod]
        public void Book_Names_Reg_BBK()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Reg_BBK(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Regs_BBK()
        {
            //Arrange
            string name = "46.73";
            //Act
            bool actual = AddBook.Reg_BBK(name);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
//Reg_Number
        public void Book_Names_Reg_Number()
        {
            //Arrange
            string name = "";
            //Act
            bool actual = AddBook.Reg_Number(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_Numbers()
        {
            //Arrange
            string name = "46.73";
            //Act
            bool actual = AddBook.Reg_Number(name);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Book_Names_Reg_Numberss()
        {
            //Arrange
            string text = "46";
            //Act
            bool actual = AddBook.Reg_Number(text);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        // Проверка на Пользователя
        /// </summary>
//FIO
        [TestMethod]
        public void User_FIO()
        {
            //Arrange
            string text = "";
            //Act
            bool actual = AddUser.Reg_FIO(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_FIO_flases()
        {
            //Arrange
            string text = ";asd";
            //Act
            bool actual = AddUser.Reg_FIO(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_FIO_false()
        {
            //Arrange
            string text = "Тест";
            //Act
            bool actual = AddUser.Reg_FIO(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_FIO_trues()
        {
            //Arrange
            string text = "Тест Тест Тест";
            //Act
            bool actual = AddUser.Reg_FIO(text);
            //Assert
            Assert.IsFalse(actual);
        }
//Reg_Login
        [TestMethod]
        public void User_Reg_Login_false()
        {
            //Arrange
            string text = "";
            //Act
            bool actual = AddUser.Reg_Login(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_Reg_Login_falses()
        {
            //Arrange
            string text = "Тест;a-=";
            //Act
            bool actual = AddUser.Reg_Login(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_Reg_Login_fals()
        {
            //Arrange
            string text = "Limisk";
            //Act
            bool actual = AddUser.Reg_Login(text);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Reg_Login_falss()
        {
            //Arrange
            string text = "Limisk01";
            //Act
            bool actual = AddUser.Reg_Login(text);
            //Assert
            Assert.IsTrue(actual);
        }
//Reg_Password
        [TestMethod]
        public void User_Reg_Reg_Password()
        {
            //Arrange
            string text = "";
            //Act
            bool actual = AddUser.Reg_Password(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_Reg_Reg_Passwors()
        {
            //Arrange
            string text = "1748801241m";
            //Act
            bool actual = AddUser.Reg_Password(text);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void User_Reg_Reg_Passw()
        {
            //Arrange
            string text = "1748801241mM";
            //Act
            bool actual = AddUser.Reg_Password(text);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Reg_Reg_Pass()
        {
            //Arrange
            string text = "1748801241mM;!@#";
            //Act
            bool actual = AddUser.Reg_Password(text);
            //Assert
            Assert.IsTrue(actual);
        }
    }
}
