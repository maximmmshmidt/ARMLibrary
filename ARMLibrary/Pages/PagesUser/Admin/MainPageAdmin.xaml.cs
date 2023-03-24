using ARMLibrary.Models;
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

namespace ARMLibrary.Pages.PagesUser.Admin
{
    /// <summary>
    /// Логика взаимодействия для MainPageAdmin.xaml
    /// </summary>
    public partial class MainPageAdmin : Page
    {
        
        readonly Core db = new Core();
        public MainPageAdmin()
        {
            InitializeComponent();
            
            Navigating.Navigate(new BookPage());
            
            ProfilBT.Opacity = 1;
            AddUser.Opacity = 1;
            AddBook.Opacity = 1;
            LibraryUser.Opacity = 1;
            LibraryBook.Opacity = 0.5;
        }

        private void ProfilBTClic(object sender, RoutedEventArgs e)
        {
            Navigating.Navigate(new ProfilUserPage());
            ProfilBT.Opacity = 0.5;
            AddUser.Opacity = 1;
            AddBook.Opacity = 1;
            LibraryUser.Opacity = 1;
            LibraryBook.Opacity = 1;
        }

        private void LibraryBook_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            AddUser.Opacity = 1;
            AddBook.Opacity = 1;
            LibraryUser.Opacity = 1;
            LibraryBook.Opacity = 0.5;
            Navigating.Navigate(new BookPage());
        }

        private void LibraryUser_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            AddUser.Opacity = 1;
            AddBook.Opacity =1;
            LibraryUser.Opacity = 0.5 ;
            LibraryBook.Opacity = 1;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            AddUser.Opacity = 1;
            AddBook.Opacity = 0.5;
            LibraryUser.Opacity = 1;
            LibraryBook.Opacity = 1;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            ProfilBT.Opacity = 1;
            AddUser.Opacity = 0.5;
            AddBook.Opacity = 1;
            LibraryUser.Opacity = 1;
            LibraryBook.Opacity = 1;
        }
    }
}
