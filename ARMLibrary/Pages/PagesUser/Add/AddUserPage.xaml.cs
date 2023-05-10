using ARMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ARMLibraryClass;

namespace ARMLibrary.Pages.PagesUser.Add
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        static int usAddIdViewUser = 3;
        readonly Core db = new Core();
        public AddUserPage()
        {
            InitializeComponent();
            List<ViewUser> arrGroups = new List<ViewUser>();
            arrGroups.AddRange(db.context.ViewUser.ToList());
            arrGroups.Remove(arrGroups[0]);
            ViewUs.ItemsSource = arrGroups;
            ViewUs.DisplayMemberPath = "NameViewUser";
            ViewUs.SelectedValuePath = "idViewUser";
            if (App.loginAuntificate.idViewUser == 1)
            {
                ViewUsers.Visibility = Visibility.Visible;
            }
            else
            {
                usAddIdViewUser = 3;
            }
        }

        private void AddUserLibrary(object sender, RoutedEventArgs e)
        {
            ErorTB.Text = "";
            if (usAddIdViewUser!= 0 && NumberPhoneTB != null && WorkTB!= null && AdresTB != null && YearBitrhtTB != null && PatronicTB!= null && LastNameTB!= null && FirstNameTB != null && PasswordTB != null && LoginTB != null)
            {
                var log = db.context.User.Where(x=>x.Login == LoginTB.Text);
                if (log == null && AddUser.Reg_Login(LoginTB.Text) && AddUser.Reg_Password(PasswordTB.Text) &&
                    AddUser.Reg_FIO(LastNameTB.Text) && AddUser.Reg_FIO(FirstNameTB.Text) && AddUser.Reg_FIO(PatronicTB.Text) &&
                    AddUser.DateBirth(YearBitrhtTB.Text) && AddUser.Reg_Adres(AdresTB.Text) && AddUser.NumberPhone(NumberPhoneTB.Text))
                {
                    User us = new User()
                    {
                        Login = LoginTB.Text,
                        Password = PasswordTB.Text,
                        LastName = LastNameTB.Text,
                        FirstName = FirstNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        idViewUser = ViewUs.Items.Count,
                        YearBirth = YearBitrhtTB.SelectedDate.Value,
                        ResidentialAddress = AdresTB.Text,
                        PlaceWork = WorkTB.Text,
                        NumbrePhone = NumberPhoneTB.Text,
                    };
                    db.context.User.Add(us);
                    try
                    {
                        db.context.SaveChangesAsync();
                        MessageBox.Show($"{us.ViewUser.NameViewUser} добавлен!");
                        NavigationService.GoBack();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex);
                    }
                }
                else
                {
                    ErorTB.Text += " * Данные введены не коректно";
                }
            }
            else
            {
                ErorTB.Text += " * Данные не введины";
            }
        }
    }
}
