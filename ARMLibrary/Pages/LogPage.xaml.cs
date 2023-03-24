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
        public static User us;
        readonly Core db = new Core();
        public LogPage()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            us = db.context.User.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text);
            if (us != null)
            {
                switch (us.idViewUser)
                {
                    case 1:
                        this.NavigationService.Navigate(new MainPageAdmin());
                        break;
                    case 2:
                        this.NavigationService.Navigate(new MainPageLibrarian());
                        break;
                    case 3:
                        this.NavigationService.Navigate(new MainPageReader());
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
            this.NavigationService.Navigate(new RegPage());
        }
    }
}
