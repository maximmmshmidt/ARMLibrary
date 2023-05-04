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
    /// Логика взаимодействия для ProfilUserPageForList.xaml
    /// </summary>
    public partial class ProfilUserPageForList : Page
    {
        public List<NumberBookGiven> mass;
        public ProfilUserPageForList(User activeStudent)
        {
            InitializeComponent();
            idUsers.Text += activeStudent.idUser.ToString();
            numberPhone.Text += activeStudent.NumbrePhone;
            placeWork.Text += activeStudent.PlaceWork;
            Adres.Text += activeStudent.ResidentialAddress;
            YearBirth.Text += activeStudent.YearBirth.ToString("D");
            ViewUsers.Text += activeStudent.ViewUser.NameViewUser;
            FIO.Text += activeStudent.LastName + " "+ activeStudent.FirstName + " " + activeStudent.Patronymic;
            mass = App.db.context.NumberBookGiven.Where(x => x.idUser == activeStudent.idUser).ToList();
            DataGridBook.ItemsSource = mass;
            
        }
    }
}
