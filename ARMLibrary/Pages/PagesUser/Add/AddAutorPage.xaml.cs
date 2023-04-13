using ARMLibrary.Models;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARMLibrary.Pages.PagesUser.Add
{
    /// <summary>
    /// Логика взаимодействия для AddAutorPage.xaml
    /// </summary>
    public partial class AddAutorPage : Page
    {
        readonly Core db = new Core();
        public AddAutorPage()
        {
            InitializeComponent();
        }
        
        private void Add(object sender, RoutedEventArgs e)
        {
            if (LastNameTB != null && FirstNameTB != null && PatronicTB!=null && DateBirth != null && DateDeath != null )
            {
                if (DateDeath != null)
                {
                    Author author = new Author()
                    {
                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        YearBirth = (DateTime)DateBirth.SelectedDate,
                        YearDeath = (DateTime)DateDeath.SelectedDate,
                    };
                    db.context.Author.Add(author);
                }
                else
                {
                    Author author = new Author()
                    {
                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        YearBirth = (DateTime)DateBirth.SelectedDate,
                    };
                    db.context.Author.Add(author);
                }
                
                db.context.SaveChanges();
            }
            else
            {
                System.Windows.MessageBox.Show("Заполните все данные!!!");
            }
        }
    }
}
