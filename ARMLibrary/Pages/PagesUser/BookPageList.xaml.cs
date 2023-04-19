using ARMLibrary.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            
        }
    }
}
