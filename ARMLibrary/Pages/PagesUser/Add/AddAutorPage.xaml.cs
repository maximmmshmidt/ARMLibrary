using ARMLibrary.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using MessageBox = System.Windows.Forms.MessageBox;

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
        public Author auth = new Author();
        private void Add(object sender, RoutedEventArgs e)
        {
            if (LastNameTB != null && FirstNameTB != null && PatronicTB!=null && DateBirth != null)
            {
                if (DateDeath != null)
                {
                    auth= new Author(){

                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        YearBirth = (DateTime)DateBirth.SelectedDate,
                        YearDeath = (DateTime)DateDeath.SelectedDate,
                    };
                    db.context.Author.Add(auth);
                }
                else
                {
                    auth = new Author()
                    {
                        FirstName = FirstNameTB.Text,
                        LastName = LastNameTB.Text,
                        Patronymic = PatronicTB.Text,
                        YearBirth = (DateTime)DateBirth.SelectedDate,
                    };
                    db.context.Author.Add(auth);
                }

                try
                {
                    db.context.SaveChanges();
                    MessageBox.Show($"Автор {auth.LastName} {auth.FirstName} {auth.Patronymic}, был добавлен");
                    NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка :" + ex);
                }
            }
            else
            {
                MessageBox.Show("Заполните все данные!!!");
            }
        }
    }
}
