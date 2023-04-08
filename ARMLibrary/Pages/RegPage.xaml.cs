﻿using ARMLibrary.Models;
using ARMLibrary.Pages.PagesUser.Admin;
using ARMLibrary.Pages.PagesUser.Reader;
using System.Windows;
using System.Windows.Controls;


namespace ARMLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        readonly Core db = new Core();
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            if (Librarianship.RegexClass.CheckingLogin(LoginTB.Text) && Librarianship.RegexClass.CheckingPassword(PasswordTB.Text) && PasswordTB == TwoPasswordTB)
            {
                Tenant user = new Tenant
                {
                    loginTenant = LoginTB.Text,
                    paswordTenant = PasswordTB.Text,
                    idViewUser = 4,
                };
                db.context.Tenant.Add(user);
                db.context.SaveChanges();
                this.NavigationService.Navigate(new MainPageReader());
            }
            else
            {
                MessageBox.Show("Введеные данные не коректны");
            }
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LogPage());
        }
    }
}
