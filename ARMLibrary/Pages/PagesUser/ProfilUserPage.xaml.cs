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

namespace ARMLibrary.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для ProfilUserPage.xaml
    /// </summary>
    public partial class ProfilUserPage : Page
    {
        Core db = new Core();
        public ProfilUserPage()
        {
            InitializeComponent();
            LastName.Text += App.loginAuntificate.LastName + " " + App.loginAuntificate.FirstName +" "+ App.loginAuntificate.Patronymic;
            ViewUser usrole = db.context.ViewUser.Where(x => x.idViewUser == App.loginAuntificate.idViewUser).FirstOrDefault();
            ViewUser.Text += usrole.NameViewUser;
            NumberPhone.Text += App.loginAuntificate.NumbrePhone;
            YearBirth.Text += Convert.ToString(App.loginAuntificate.YearBirth.ToString("D"));
            ResidAdres.Text += Convert.ToString(App.loginAuntificate.ResidentialAddress);
            PlaceWork.Text += Convert.ToString(App.loginAuntificate.PlaceWork);
            NumberPhone.Text += Convert.ToString(App.loginAuntificate.NumbrePhone);
            //LastName.Text = "ФИО:"
            //LastNameBox.Text =  App.loginAuntificate.LastName + " " + App.loginAuntificate.FirstName +" "+ App.loginAuntificate.Patronymic;
            //вывод из box ФИО
            //string[] mass = new string[];
            //mass = LastNameBox.Text.Split(' ');
            //User redactUser = new User(){индификация начинается с 0}
        }
    }
}
