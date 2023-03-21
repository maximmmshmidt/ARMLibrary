using System.Windows;
using System.Windows.Controls;
using ARMLibrary.Pages.PagesUser.Admin;
using ARMLibrary.Models;
using System.Linq;

namespace ARMLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>

    public partial class LogPage : Page
    {
        Core db = new Core();
        public LogPage()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            //LoginTB.Text.Where(x => x.);
        }
    }
}
