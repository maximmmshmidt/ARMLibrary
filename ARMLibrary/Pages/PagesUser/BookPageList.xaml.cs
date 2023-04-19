using ARMLibrary.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Excel = Microsoft.Office.Interop.Excel;

namespace ARMLibrary.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для BookPageList.xaml
    /// </summary>
    public partial class BookPageList : Page
    {
        readonly Core db = new Core();

        readonly Book bok;

        public BookPageList(Book book)
        {
            InitializeComponent();
            bok = book;
            NumberBooks.Text += db.context.AccountingBook.Where(x => x.idBook == book.idBook).Select(x => x.NumberBook).SingleOrDefault();
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

            worksheet.Name = "Student"; //имя листа нужно вводить латинскими буквами

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

            worksheet.Cells[1][2] = bok.NameBook;
            worksheet.Cells[2][2] = bok.NameBook;
            worksheet.Cells[3][2] = bok.NameBook;
            worksheet.Columns.AutoFit();

            //foreach (var item in bok)
            //{
            //    if (true)
            //    {
                    
            //    }
            //}
        }

    }
}
