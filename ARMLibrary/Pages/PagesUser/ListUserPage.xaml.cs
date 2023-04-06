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

        }

        private void ProfilButtonClick(object sender, RoutedEventArgs e)
        {
            //User activeStudent = ((Button)sender).DataContext as Students;
            Button activeButton = sender as Button;
            User activeStudent = activeButton.DataContext as User;
            if (activeStudent != null)
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

        }
    }
}
