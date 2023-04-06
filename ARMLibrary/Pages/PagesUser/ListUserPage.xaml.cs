using ARMLibrary.Models;
using ARMLibrary.Pages.PagesUser.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ARMLibrary.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для ListUserPage.xaml
    /// </summary>
    public partial class ListUserPage : Page
    {
        readonly Core db = new Core();
        public List<User> mass;

        public List<string> filterUser = new List<string>()
        {
            "Фамилия",
            "Имя",
            "Отчество",
            "Адрес Прожив.",
            "Раб.\\Учеба",
            "Номер тел.",
        };

        public ListUserPage()
        {
            InitializeComponent();
            mass = db.context.User.ToList();
            mass = mass.Where(x => x.idViewUser != App.loginAuntificate.idViewUser).ToList();
            if (App.loginAuntificate.idViewUser > 1)
            {
                mass = mass.Where(x => x.idViewUser != 1).ToList();
            }
            DataGridUser.ItemsSource = mass;

            FilterUser.ItemsSource = filterUser;
        }

        private void ProfilButtonClick(object sender, RoutedEventArgs e)
        {
            //User activeStudent = ((Button)sender).DataContext as Students;
            Button activeButton = sender as Button;
            if (activeButton.DataContext is User activeStudent)
            {
                this.NavigationService.Navigate(new ProfilUserPageForList(activeStudent));
            }
        }

        private void AddUserPageNav(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddUserPage());
        }

        private void FindTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataGridUser.ItemsSource = GetRows();
        }
        private List<User> GetRows()
        {
            List<User> arrayProduct = mass;
            string searchData = FindTextBox.Text.ToUpper();
            Genre genre = FilterUser.SelectedItem as Genre;
            if (!String.IsNullOrEmpty(FindTextBox.Text))
            {
                DataGridUser.ItemsSource = null;
                arrayProduct = arrayProduct.Where(x => x.LastName.ToUpper().Contains(searchData)).ToList();
            }
            if (String.IsNullOrEmpty(FindTextBox.Text))
            {
                return mass;
            }
            //if (!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 0)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.LastName.ToUpper().Contains(searchData)).ToList();
            //}
            //else if(!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 1)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.FirstName.ToUpper().Contains(searchData)).ToList();
            //}
            //else if (!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 2)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.Patronymic.ToUpper().Contains(searchData)).ToList();
            //}
            //else if (!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 3)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.ResidentialAddress.ToUpper().Contains(searchData)).ToList();
            //}
            //else if(!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 4)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.PlaceWork.ToUpper().Contains(searchData)).ToList();
            //}
            //else if(!String.IsNullOrEmpty(FindTextBox.Text) && genre.idGenre == 5)
            //{
            //    DataGridUser.ItemsSource = null;
            //    arrayProduct = arrayProduct.Where(x => x.NumbrePhone.ToUpper().Contains(searchData)).ToList();
            //}
            return arrayProduct;
        }

        private void FilterUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
