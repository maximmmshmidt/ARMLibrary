﻿using ARMLibrary.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using ARMLibraryClass;
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
                
                if ( AddAuthor.Reg_FIO(FirstNameTB.Text) && AddAuthor.Reg_FIO(LastNameTB.Text) && AddAuthor.Reg_FIO(PatronicTB.Text))
                {

                    if (DateDeath == null)
                    {
                        auth = new Author()
                        {

                            FirstName = FirstNameTB.Text,
                            LastName = LastNameTB.Text,
                            Patronymic = PatronicTB.Text,
                            YearBirth = DateBirth.SelectedDate.Value,
                            YearDeath = DateDeath.SelectedDate.Value,
                        };
                    }
                    else
                    {
                        auth = new Author()
                        {

                            FirstName = FirstNameTB.Text,
                            LastName = LastNameTB.Text,
                            Patronymic = PatronicTB.Text,
                            YearBirth = DateBirth.SelectedDate.Value,
                        };
                    }
                    try
                    {
                        db.context.Author.Add(auth);
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
                    MessageBox.Show(" * Данные введены не коректно");
                }
            }
            else
            {
                MessageBox.Show("Заполните все данные!!!");
            }
        }
    }
}
