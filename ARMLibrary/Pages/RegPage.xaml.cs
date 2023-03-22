using ARMLibrary.Pages.PagesUser.Admin;
using ARMLibrary.Pages.PagesUser.Reader;
using System.Windows;
using System.Windows.Controls;


namespace ARMLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            if (Librarianship.RegexClass.CheckingLogin(LoginTB.Text) && Librarianship.RegexClass.CheckingPassword(PasswordTB.Text) && PasswordTB == TwoPasswordTB)
            {
                this.NavigationService.Navigate(new MainPageReader());
            }
            else
            {
                MessageBox.Show("Введеные данные не коректны");
            }
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LogPage());
        }
    }
}
