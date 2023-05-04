using ARMLibrary.Models;
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
        public AddBookPage()
        {
            InitializeComponent();
            var author = new List<Author>();
            author.AddRange(App.db.context.Author.ToList());

            AutorTB.ItemsSource = author;
            AutorTB.SelectedValuePath = "idAuthor";


            var arrGroups = new List<Genre>();
            arrGroups.AddRange(App.db.context.Genre.ToList());

            IdJanreTB.ItemsSource = arrGroups;
            IdJanreTB.DisplayMemberPath = "NameGenre";
            IdJanreTB.SelectedValuePath = "idGenre";

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (true)
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
                App.db.context.Book.Add(book);
                try
                {
                    App.db.context.SaveChanges();
                    MessageBox.Show("Вы Взяли книгу");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка :" + ex);
                }
            }
        }

        private void IdJanreTB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
