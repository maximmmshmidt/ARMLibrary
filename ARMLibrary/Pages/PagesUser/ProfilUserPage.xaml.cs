using ARMLibrary.Models;
using DocumentFormat.OpenXml.Math;
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

namespace ARMLibrary.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для ProfilUserPage.xaml
    /// </summary>
    public partial class ProfilUserPage : Page
    {
        readonly Core db = new Core();
        public ProfilUserPage()
        {
            InitializeComponent();
            //если пользователь вошел в систему
            if (App.loginAuntificate!= null)
            {
                LastName.Text += App.loginAuntificate.LastName + " " + App.loginAuntificate.FirstName + " " + App.loginAuntificate.Patronymic;
                ViewUser usrole = db.context.ViewUser.Where(x => x.idViewUser == App.loginAuntificate.idViewUser).FirstOrDefault();
                ViewUser.Text += usrole.NameViewUser;
                NumberPhone.Text += App.loginAuntificate.NumbrePhone;
                YearBirth.Text += Convert.ToString(App.loginAuntificate.YearBirth.ToString("D"));
                ResidAdres.Text += Convert.ToString(App.loginAuntificate.ResidentialAddress);
                PlaceWork.Text += Convert.ToString(App.loginAuntificate.PlaceWork);
            }
            // если нет то дается возможность зарегаться
            else
            {
                InfoPolzov.Visibility = Visibility.Hidden;
            }
        }

        private void AddUserPageNav(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }
    }
}
