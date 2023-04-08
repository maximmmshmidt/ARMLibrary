using ARMLibrary.Models;
using ARMLibrary.Pages.PagesUser.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Navigating.Navigate(new BookPage());

            ProfilBT.Opacity = 1;
            LibraryBook.Opacity = 0.5;
        }

        private void ProfilBTClic(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LogPage());
            ProfilBT.Opacity = 0.5;
            LibraryBook.Opacity = 1;
        }

        private void LibraryBook_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            LibraryBook.Opacity = 0.5;
            Navigating.Navigate(new BookPage());
        }


        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            LibraryBook.Opacity = 1;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            LibraryBook.Opacity = 1;
        }
    }
}
