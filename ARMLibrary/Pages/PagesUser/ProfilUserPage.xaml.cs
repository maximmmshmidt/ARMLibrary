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
        string[] mass;
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

            }
        }

        bool editBT = true;

        private void RedactionBTClic(object sender, RoutedEventArgs e)
        {
            if (editBT)
            {
                EditBT.Opacity = 0.5;
                editBT = false;
                HideTB.Visibility = Visibility.Visible;

                LastName.Text = "ФИО : ";
                LastNameBox.Text = App.loginAuntificate.LastName + " " + App.loginAuntificate.FirstName + " " + App.loginAuntificate.Patronymic;

                NumberPhone.Text = App.loginAuntificate.NumbrePhone;
                NumberPhoneBox.Text = "Номер Телефона : ";

                YearBirth.Text = Convert.ToString(App.loginAuntificate.YearBirth.ToString("D"));
                YearBirthBox.Text = "Дата Рождения : ";

                ResidAdres.Text = Convert.ToString(App.loginAuntificate.ResidentialAddress);
                ResidAdresBox.Text = "Место Проживания : ";

                PlaceWork.Text = Convert.ToString(App.loginAuntificate.PlaceWork);
                PlaceWorkBox.Text = "Место Учебы\\Работы : ";
            }
            else
            {
                EditBT.Opacity = 1;
                editBT = true;
                HideTB.Visibility = Visibility.Hidden;
            }
        }

        bool save = true;

        private void SaveBTClic(object sender, RoutedEventArgs e)
        {
            if (save && LastName.Text.Length < 10 && Librarianship.RegexClass.CheckingСyrillic(LastName.Text))
            {
                save = false;
                mass = LastNameBox.Text.Split(' ');
                _ = new User()
                {
                    LastName = mass[0],
                    FirstName = mass[0],
                    Patronymic = mass[0]
                };
            }
            else
            {
                SaveBT.Opacity = 0.5;
            }
        }
    }
}
