using ARMLibrary.Models;
using ARMLibraryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace ARMLibrary.Pages.PagesUser.Add
{
    /// <summary>
    /// Логика взаимодействия для AddBookPage.xaml
    /// </summary>
    public partial class AddBookPage : Page
    {
        readonly Core db = new Core();
        public AddBookPage()
        {
            InitializeComponent();
            var author = new List<Author>();
            author.AddRange(db.context.Author.ToList());

            AutorTB.ItemsSource = author;
            AutorTB.SelectedValuePath = "idAuthor";


            List<Genre> arrGroups = new List<Genre>();
            arrGroups.AddRange(db.context.Genre.ToList());
            arrGroups.Remove(arrGroups[0]);

            IdJanreTB.ItemsSource = arrGroups;
            IdJanreTB.DisplayMemberPath = "NameGenre";
            IdJanreTB.SelectedValuePath = "idGenre";

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (NameBookTB!= null && IdJanreTB.Items.Count !=0 && AutorTB.Items.Count != 0 &&
                PublicationHouseTB != null && PlacePublTB != null && YearPublTB != null &&
                NumberPage != null && IsbnTB != null && BbkTB != null && DescripTB != null)
            {
                if (AddBook.Reg_NameBook(NameBookTB.Text) && AddBook.Reg_PublishingHouse(PublicationHouseTB.Text) &&
                    AddBook.Reg_PlacePublication(PlacePublTB.Text) && AddBook.Reg_Number(NumberPage.Text)&&
                    AddBook.Gg_IBN(IsbnTB.Text) && AddBook.Reg_BBK(BbkTB.Text))
                {
                    var num = Convert.ToInt16(NumberPage.Text);
                    Book book = new Book()
                    {
                        NameBook = NameBookTB.Text,
                        idAuthor = AutorTB.Items.Count,
                        idGenre = IdJanreTB.Items.Count,
                        PublishingHouse = PublicationHouseTB.Text,
                        PlacePublication = PlacePublTB.Text,
                        YearPublication = YearPublTB.SelectedDate.Value,
                        NumberPages = num,
                        ISBN = IsbnTB.Text,
                        BBK = BbkTB.Text,
                        Description = DescripTB.Text
                    };
                    db.context.Book.Add(book);
                    try
                    {
                        db.context.SaveChangesAsync();
                        MessageBox.Show($"Книга {book.NameBook},была добавлена");
                        NavigationService.GoBack();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Данные введены не коректно");
                }
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }

        private void IdJanreTB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
