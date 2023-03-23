using ARMLibrary.Pages;
using ARMLibrary.Pages.PagesUser.Admin;
using System.Windows;


namespace ARMLibrary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LogPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPageAdmin());
        }

        private void RollUpButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void UnwrapButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
