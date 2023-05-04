using System.Windows;
using System.Windows.Controls;
using ARMLibrary.Pages.PagesUser.Admin;
using ARMLibrary.Pages.PagesUser.Librarian;
using ARMLibrary.Pages.PagesUser.Reader;
using ARMLibrary.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ARMLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>

    public partial class LogPage : Page
    {
        readonly Core db = new Core();
        public LogPage()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            User us = db.context.User.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text);
            App.loginAuntificate = us;
            if (us != null)
            {
                switch (us.idViewUser)
                {
                    case 1:
                        NavigationService.Navigate(new MainPageAdmin());
                        break;
                    case 2:
                        NavigationService.Navigate(new MainPageLibrian());
                        break;
                    case 3:
                        NavigationService.Navigate(new MainPageReader());
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Данные Введины не верно");
            }
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}
