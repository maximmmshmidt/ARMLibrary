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
            var us = db.context.User.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text);
            if (us != null)
            {
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
