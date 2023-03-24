﻿using ARMLibrary.Models;
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

namespace ARMLibrary.Pages.PagesUser.Reader
{
    /// <summary>
    /// Логика взаимодействия для MainPageReader.xaml
    /// </summary>
    public partial class MainPageReader : Page
    {
        public MainPageReader()
        {
            InitializeComponent();
        }

        private void ProfilBTClic(object sender, RoutedEventArgs e)
        {
            Navigating.Navigate(new ProfilUserPage());
        }
    }
}
