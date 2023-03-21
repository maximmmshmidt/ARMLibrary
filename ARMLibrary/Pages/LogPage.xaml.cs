using System.Windows;
using System.Windows.Controls;
using ARMLibrary.Pages.PagesUser.Admin;
using ARMLibrary.Models;
using System.Linq;
using System.Collections.Generic;

namespace ARMLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>

    public partial class LogPage : Page
    {
        Core db = new Core();
        public LogPage()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            List<User> us = db.context.User.Where(x => x.Login == LoginTB.Text).ToList();
            if (us != null && us[2].ToString() == PasswordTB.Text)
            {
                MessageBox.Show("Вход был успешно выполнен");
                this.NavigationService.Navigate(new MainPageAdmin());
            }
            else
            {
                MessageBox.Show("Данные Введины не верно");
            }
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }
    }
}
