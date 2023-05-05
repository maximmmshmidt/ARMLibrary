using ARMLibrary.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ARMLibrary.Pages.PagesUser.Add
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public static int usAddIdViewUser = 0;
        readonly Core db = new Core();
        public AddUserPage()
        {
            InitializeComponent();
            if (App.loginAuntificate.idViewUser == 1)
            {
                VisibleVid.Visibility = Visibility.Visible;
            }
            else
            {
                usAddIdViewUser = 3;
            }
        }

        private void AddUserLibrary(object sender, RoutedEventArgs e)
        {
            if (NumberPhoneTB != null && WorkTB!= null && AdresTB != null && YearBitrhtTB != null && PatronicTB!= null && LastNameTB!= null && FirstNameTB != null && PasswordTB != null && LoginTB != null)
            {
                if (true)
                {
                    User us = new User()
                    {
                        Login = LoginTB.Text,
                        Password = PasswordTB.Text,
                        LastName = LastNameTB.Text,
                        FirstName = FirstNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        idViewUser = usAddIdViewUser,
                        YearBirth = (DateTime)YearBitrhtTB.DataContext,
                        ResidentialAddress = AdresTB.Text,
                        PlaceWork = WorkTB.Text,
                        NumbrePhone = NumberPhoneTB.Text,
                    };
                    db.context.User.Add(us);
                    try
                    {
                        db.context.SaveChangesAsync();
                        MessageBox.Show("Пользов добавлен!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex);
                    }
                }   
            }
            else
            {
                MessageBox.Show("Данные не введины");
            }
        }

        private void Biblioteck_Click(object sender, RoutedEventArgs e)
        {
            Biblioteck.Opacity = 0.5;
            Reader.Opacity = 1;
            usAddIdViewUser = 2;
        }

        private void Reader_Click(object sender, RoutedEventArgs e)
        {
            Biblioteck.Opacity = 1;
            Reader.Opacity = 0.5;
            usAddIdViewUser = 3;
        }
    }
}
