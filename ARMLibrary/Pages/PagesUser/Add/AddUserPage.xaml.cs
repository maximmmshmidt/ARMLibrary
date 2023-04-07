using ARMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARMLibrary.Pages.PagesUser.Add
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        readonly Core db = new Core();
        public int usAddIdViewUser = 0;
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
                    User user = new User()
                    {
                        LastName = LastNameTB.Text,
                        FirstName = FirstNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        Password = PasswordTB.Text,
                        Login = LoginTB.Text,
                        idViewUser = usAddIdViewUser,
                        YearBirth = (DateTime)YearBitrhtTB.DataContext,
                        ResidentialAddress = AdresTB.Text,
                        PlaceWork = WorkTB.Text,
                        NumbrePhone = NumberPhoneTB.Text,
                    };
                    db.context.User.Add(user);
                    db.context.SaveChanges();
                }   
            }
            else
            {
                MessageBox.Show("Данные не введины");
            }
        }

        private void Biblioteck_Click(object sender, RoutedEventArgs e)
        {
            usAddIdViewUser = 2;
        }

        private void Reader_Click(object sender, RoutedEventArgs e)
        {
            usAddIdViewUser = 3;
        }
    }
}
