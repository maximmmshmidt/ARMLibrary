using ARMLibrary.Models;
using System;
using System.Linq;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using ARMLibrary;
using System.Data.Entity.Migrations;
using System.Windows.Documents;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ARMLibrary.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для BookPageList.xaml
    /// </summary>
    public partial class BookPageList : System.Windows.Controls.Page
    {

        readonly Book bok;
        readonly Core db = new Core();


        public BookPageList(Book book)
        {
            InitializeComponent();
            bok = book;
            NumberBooks.Text += db.context.AccountingBooks.Where(x => x.idBook == book.idBook).Select(x => x.NumberBook).SingleOrDefault();
            NameBookTB.Text = book.NameBook;
            DescriptionTB.Text = book.Description;
            BBKTB.Text += book.BBK;
            ISBNTB.Text += book.ISBN;
            NumberBagesTB.Text += book.NumberPages;
            YearPublicationTB.Text += book.YearPublication.ToString("d");
            PlacePublicationTB.Text += book.PlacePublication;
            PublishingHouseTB.Text += book.PublishingHouse;
            GenreTB.Text += book.Genre.NameGenre;
            AuthorTB.Text += book.Author.LastName + " " + book.Author.FirstName + " " + book.Author.Patronymic;

            if (App.loginAuntificate.idViewUser > 2)
            {
                Excel.Visibility = Visibility.Hidden;
            }
            else
            {
                Excel.Visibility = Visibility.Visible;
            }
            if (book.ImageBook != null)
            {
                ImageBookNone.Visibility = Visibility.Hidden;
                ImageBook.Visibility = Visibility.Visible;
                ImageBook.Source = new BitmapImage( new Uri(book.ImageBook.ToString())); 
            }
        }
        
        private void ExcelBTClick(object sender, RoutedEventArgs e)   
        {
            List<NumberBookGiven> numberBookGiven = db.context.NumberBookGiven.Where(x => x.AccountingBook == bok.idBook).ToList();
            /*создаем файл Excel*/

            var aplication = new Excel.Application
            {
                Visible = true,

                /*количество листов*/

                SheetsInNewWorkbook = 1
            };

            /*добавляем рабочую книгу*/

            Excel.Workbook workbook = aplication.Workbooks.Add(Type.Missing);

            /*создаем лист*/

            Excel.Worksheet worksheet = workbook.ActiveSheet;

            worksheet.Name = "BookForGiven"; //имя листа нужно вводить латинскими буквами

            /*заголовки вывод в Excel (в первую строку)*/

            worksheet.Cells[1][1] = "Дата выдачи";
            worksheet.Cells[2][1] = "Срок возварта";
            worksheet.Cells[3][1] = "Отдел фонда";
            worksheet.Cells[4][1] = "Автор";
            worksheet.Cells[5][1] = "Название книги";
            worksheet.Cells[6][1] = "Подпись Чит";
            worksheet.Cells[7][1] = "Подпись Библ";
            worksheet.Cells[8][1] = "Примечаниея";

            worksheet.Cells[8][1].font.bold = true;
            worksheet.Cells[7][1].font.bold = true;
            worksheet.Cells[6][1].font.bold = true;
            worksheet.Cells[5][1].font.bold = true;
            worksheet.Cells[4][1].font.bold = true;
            worksheet.Cells[3][1].font.bold = true;
            worksheet.Cells[2][1].font.bold = true;
            worksheet.Cells[1][1].font.bold = true;

            /*вывод данных из массива в Excel*/



            int rowIndex = 2;

            foreach (var item in numberBookGiven)
            {
                worksheet.Cells[1][rowIndex] = item.DateIssue;
                worksheet.Cells[2][rowIndex] = item.ReturnDate;
                worksheet.Cells[3][rowIndex] = bok.PublishingHouse;
                worksheet.Cells[4][rowIndex] = bok.Author.LastName + " " + bok.Author.FirstName + " " + bok.Author.Patronymic;
                worksheet.Cells[5][rowIndex] = bok.NameBook;
                worksheet.Cells[6][rowIndex] = item.User.FirstName + " "
                    + item.User.LastName[0].ToString().ToUpper() 
                    + "." + item.User.Patronymic[0].ToString().ToUpper() + ".";
                if (item.ReturnedBook == true)
                {
                    worksheet.Cells[7][rowIndex] = "(❁´◡`❁)";
                    worksheet.Cells[8][rowIndex] = "Отдал во время";
                }
                else
                {
                    worksheet.Cells[7][rowIndex] = "(╯°□°）╯︵ ┻━┻";
                    worksheet.Cells[8][rowIndex] ="Срок сдачи просрочен";
                }
                worksheet.Columns.AutoFit();
                rowIndex++;
            }
        }
        AccountingBooks accountingBok = new AccountingBooks();
        bool bol;
        private void TakeBook(object sender, RoutedEventArgs e)
        {
            var us = db.context.NumberBookGiven.Where(x => x.idUser == App.loginAuntificate.idUser);
            accountingBok = db.context.AccountingBooks.Where(x => x.idBook == bok.idBook).SingleOrDefault();
            foreach (var item in us)
            {
                if (item.ReturnDate >= DateTime.Now && item.BuyBook == false && item.ReturnedBook == false)
                {
                    Console.WriteLine(item.AccountingBooks.Book.NameBook);
                    MessageBox.Show("Вы еще не сдали другю книгу");
                    bol = false;
                    return;
                }
                else
                {
                    bol = true;
                }
            }
            if(bol && accountingBok.NumberBook != 0)
            {
                NumberBookGiven numberBookGiven = new NumberBookGiven()
                {
                    IdBookGiven = 12,
                    AccountingBook = Convert.ToInt32(bok.idBook),
                    idUser = Convert.ToInt32(App.loginAuntificate.idUser),
                    DateIssue = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(14),
                    ReturnedBook = false,
                    BuyBook = false,
                };
                accountingBok.NumberBook -= 1;
                accountingBok.NumberBookGiven += 1;
                db.context.NumberBookGiven.Add(numberBookGiven);
                db.context.AccountingBooks.AddOrUpdate(accountingBok);
                try
                {
                    db.context.SaveChangesAsync();
                    MessageBox.Show("Вы Взяли книгу");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка :" + ex );
                }
            }
        }
    }
} 